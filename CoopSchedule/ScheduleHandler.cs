using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoopSchedule;

public static class ScheduleHandler
{
    public class ScheduleTable
    {
        private readonly uint[][] _table;
        private readonly uint[] _possibleStates;
        private readonly Random _random = new Random();

        public ScheduleTable(uint rows, uint columns, uint states)
        {
            // since units ∈ ℕ, a cast to uint is safe since ((b ∈ ℕ) ** (p ∈ ℕ)) ∈ ℕ (totality)
            var unobservedState = (uint) Math.Pow(2, states) - 1;
            _possibleStates = new uint[states];
            for (var i = 0; i < states; i++)
            {
                _possibleStates[i] = (uint) Math.Pow(2, i);
            }

            _table = new uint[rows][];
            for (var i = 0; i < rows; i++)
            {
                _table[i] = new uint[columns];
                for (var j = 0; j < columns; j++)
                {
                    _table[i][j] = unobservedState;
                }
            }
        }

        public uint[] this[uint row] => _table[row];

        public uint this[uint row, uint column]
        {
            get => _table[row][column];
            private set => _table[row][column] = value;
        }

        public uint Collapse(uint row, uint column)
        {
            var currentState = this[row, column];
            var possibleStates = _possibleStates.Where(state => (currentState & state) != 0).ToArray();
            var newState = possibleStates[_random.Next(possibleStates.Length)];
            this[row, column] = newState;
            return newState;
        }

        public void ConstrainRow(uint row, uint state)
        {
            for (uint i = 0; i < _table[row].Length; i++)
            {
                if (this[row, i] != state && (this[row, i] & state) != 0)
                {
                    this[row, i] ^= state;
                }
            }
        }

        public void ConstrainColumn(uint column, uint state, uint maxAppearances)
        {
            var columnArray = _table.Select(row => row[column]).ToArray();
            var columnCount = columnArray.Count(part => part == state);
            if (columnCount != maxAppearances) return;
            for (uint i = 0; i < _table.Length; i++)
            {
                if (this[i, column] != state && (this[i, column] & state) != 0)
                {
                    this[i, column] ^= state;
                }
            }
        }

        private double GetShannonEntropy(uint row, uint column)
        {
            var currentState = this[row, column];
            var possibleStates = _possibleStates.Count(state => (currentState & state) != 0);
            if (possibleStates is 1 or 0) return 0;
            var probability = 1.0 / possibleStates;
            return possibleStates * (-probability * Math.Log(probability, 2));
        }

        public (uint row, uint col)? GetSmallestShannonEntropy()
        {
            var smallestEntropy = double.MaxValue;
            (uint row, uint col) coords = (uint.MaxValue, uint.MaxValue);
            for (uint i = 0; i < _table.Length; i++)
            {
                for (uint j = 0; j < _table[i].Length; j++)
                {
                    var entropy = GetShannonEntropy(i, j);
                    if (entropy == 0 || !(entropy < smallestEntropy)) continue;
                    smallestEntropy = entropy;
                    coords = (i, j);
                }
            }

            return coords.row == uint.MaxValue ? null : coords;
        }
    }

    public static ScheduleTable GenerateTable(int students, int days, int[] states)
    {
        var table = new ScheduleTable((uint) students, (uint) days, (uint) states.Length);

        // The table should collapse
        var targetCollapses = students * days;
        var currentStage = 0;

        while (currentStage < targetCollapses)
        {
            var coords = table.GetSmallestShannonEntropy();

            // If we've reached a point where shannon entropy is all 0, we've reached the end
            if (!coords.HasValue) break;

            var newState = table.Collapse(coords.Value.row, coords.Value.col);
            // Should never be a double, if it is: (i can't swear bc this is for school) fudge
            var colMax = (uint) states[(int) Math.Log(newState, 2)];
            table.ConstrainRow(coords.Value.row, newState);
            table.ConstrainColumn(coords.Value.col, newState, colMax);
            currentStage++;
        }

        return table;
    }

    public static void OutputTable(ScheduleTable table, IReadOnlyList<string> studentNames, IReadOnlyList<string> unitNames, string path)
    {
        const string separator = ",";
        
        var output = "";
        for (uint i = 0; i < studentNames.Count; i++)
        {
            output += studentNames[(int) i] + separator;
            for (uint j = 0; j < table[i].Length; j++)
            {
                output += unitNames[(int) Math.Log(table[i, j], 2)] + (j == table[i].Length - 1 ? "" : separator);
            }

            output += "\n";
        }

        try
        {
            File.WriteAllText(path, output);
        }
        catch (IOException)
        {
            MessageBox.Show(@"There was an error while saving the file, make sure this file isn't open in another program.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
