using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CoopSchedule.External;

namespace CoopSchedule;

public partial class CoopForm : Form
{
    private const string FileName = "data.json";
    private const string CommaEscape = "&comm;";
    private const string SemiEscape = "&semi;";
    private PersistentData _persistentData;

    public CoopForm()
    {
        InitializeComponent();
    }

    #region Generation

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        var diag = new SaveFileDialog
        {
            Filter = @"CSV Files (*.csv)|*.csv",
            AddExtension = true,
            DefaultExt = ".csv",
            Title = @"Save Schedule",
            FileName = $"Schedule-{DateTime.Now:yyyy-MM-dd}",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        };

        if (diag.ShowDialog() != DialogResult.OK) return;

        var previousUnits = _persistentData.Students.Select(s => { return s.units.Select(u => _persistentData.Units.FindIndex(u2 => u2.Name == u)).ToArray(); });

        var maxAppearances = _persistentData.Units.Select(u => u.MaxStudents).ToArray();

        var newTable = ScheduleHandler.GenerateTable(
            _persistentData.Students.Count,
            (int) numDays.Value,
            maxAppearances,
            previousUnits.ToArray()
        );

        if (!newTable.CheckValid(maxAppearances))
        {
            MessageBox.Show(
                @"Invalid schedule generated. There may not be enough units for each student. Please try again or clear previous units for students",
                @"Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        var unitNames = _persistentData.Units.Select(u => u.Name).ToArray();

        for (uint i = 0; i < _persistentData.Students.Count; i++)
            _persistentData.Students[(int) i].units.AddRange(
                newTable[i].Select(
                    u => unitNames[(int) Math.Log(u, 2)]
                )
            );

        _persistentData.Save(FileName);

        ResetStudentsListBox();

        ScheduleHandler.OutputTable(
            newTable,
            _persistentData.Students.Select(s => s.name).ToArray(),
            unitNames,
            diag.FileName
        );

        var result = MessageBox.Show(
            @"Done, would you like to open the schedule?",
            @"Done",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes) Process.Start(diag.FileName);
    }

    #endregion

    #region Data

    private void CoopForm_Load(object sender, EventArgs e)
    {
        _persistentData = PersistentData.Load(FileName);
        ResetUnitListBox();
        ResetStudentsListBox();
        btnSwitchSession.Text = $"Switch To {_persistentData.CurrentSession}";
    }

    private void CoopForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _persistentData.Save(FileName);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        _persistentData.Save(FileName);
    }

    private void resetStudentUnitsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"This will clear the previous units all students have been in, are you sure?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        _persistentData.Students.ForEach(s => s.units.Clear());
        ResetStudentsListBox();
    }

    private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"This will clear ALL data, are you sure?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        _persistentData = PersistentData.DefaultData;
        _persistentData.Save(FileName);
        ResetUnitListBox();
        ResetStudentsListBox();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

    #region Units

    private void ResetUnitListBox()
    {
        var currentIndex = lstUnits.SelectedIndex;
        lstUnits.Items.Clear();
        lstUnits.Items.AddRange(_persistentData.Units.ToArray());
        lstUnits.SelectedIndex = currentIndex < lstUnits.Items.Count ? currentIndex : -1;
        if (lstUnits.Items.Count == 0) grpActiveUnit.Visible = false;
    }

    private void importToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        var diag = new OpenFileDialog
        {
            Filter = @"CSV Files (*.csv)|*.csv",
            DefaultExt = ".csv",
            Title = @"Import Units"
        };

        if (diag.ShowDialog() != DialogResult.OK) return;

        var units = File.ReadAllLines(diag.FileName);
        var newUnits = new List<UnitData>();

        foreach (var unit in units)
        {
            var split = unit.Split(',');
            if (split.Length != 2) continue;
            if (!int.TryParse(split[1], out var max)) continue;
            newUnits.Add(new UnitData
            {
                MaxStudents = max,
                Name = split[0].Replace(CommaEscape, ",")
            });
        }

        _persistentData.Units.AddRange(newUnits);
        ResetUnitListBox();
    }

    private void exportToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        var diag = new SaveFileDialog
        {
            Filter = @"CSV Files (*.csv)|*.csv",
            AddExtension = true,
            DefaultExt = ".csv",
            Title = @"Export Units"
        };

        if (diag.ShowDialog() != DialogResult.OK) return;

        var units = _persistentData.Units.Select(u => $"{u.Name.Replace(",", CommaEscape)},{u.MaxStudents}");
        File.WriteAllLines(diag.FileName, units);
    }

    private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"This will clear all units, are you sure?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        _persistentData.Units.Clear();
        ResetUnitListBox();
    }

    private void btnAddUnit_Click(object sender, EventArgs e)
    {
        var unit = new UnitData
        {
            Name = "New Unit",
            MaxStudents = 1
        };
        _persistentData.Units.Add(unit);
        ResetUnitListBox();
    }

    private void btnRemoveUnit_Click(object sender, EventArgs e)
    {
        if (lstUnits.SelectedIndex < 0) return;
        _persistentData.Units.RemoveAt(lstUnits.SelectedIndex);
        ResetUnitListBox();
    }

    private void ShowUnit(UnitData unit)
    {
        grpActiveUnit.Visible = true;
        txtUnitName.Text = unit.Name;
        txtUnitStudents.Text = unit.MaxStudents.ToString();
        var maxCycles = _persistentData.Students.Count / unit.MaxStudents;
        lblCyclesLeft.Text = (maxCycles - _persistentData.Students.Count(s => s.units.Contains(unit.Name))).ToString();
        var txtColor = lblCyclesLeft.Text == "0" ? Color.Red : Color.Black;
        lblCyclesLeft.ForeColor = txtColor;
        lblCyclesLabel.ForeColor = txtColor;
    }

    private void txtUnitName_TextChanged(object sender, EventArgs e)
    {
        if (lstUnits.SelectedItem is UnitData) _persistentData.Units[lstUnits.SelectedIndex].Name = txtUnitName.Text;
        lstUnits.Items[lstUnits.SelectedIndex] = _persistentData.Units[lstUnits.SelectedIndex];
    }

    private void txtUnitStudents_TextChanged(object sender, EventArgs e)
    {
        if (lstUnits.SelectedItem is not UnitData) return;
        try
        {
            _persistentData.Units[lstUnits.SelectedIndex].MaxStudents = int.Parse(txtUnitStudents.Text);
        }
        catch (FormatException)
        {
            // Don't save the value
        }

        lstUnits.Items[lstUnits.SelectedIndex] = _persistentData.Units[lstUnits.SelectedIndex];
    }

    private void lstUnits_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstUnits.SelectedItem is UnitData data)
            ShowUnit(data);
        else
            grpActiveUnit.Visible = false;
    }

    #endregion

    #region Students

    private void ResetStudentsListBox()
    {
        var currentIndex = lstStudents.SelectedIndex;
        lstStudents.Items.Clear();
        lstStudents.Items.AddRange(_persistentData.Students.ToArray());
        lstStudents.SelectedIndex = currentIndex < lstStudents.Items.Count ? currentIndex : -1;
        if (lstStudents.Items.Count == 0) grpActiveStudent.Visible = false;
        if (lstUnits.SelectedIndex != -1) ShowUnit(_persistentData.Units[lstUnits.SelectedIndex]);
        if (lstStudents.SelectedIndex == -1) return;
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(_persistentData.Students[lstStudents.SelectedIndex].units.ToArray());
    }

    private void importToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var diag = new OpenFileDialog
        {
            Filter = @"CSV Files|*.csv",
            Title = @"Import Students"
        };
        if (diag.ShowDialog() != DialogResult.OK) return;
        var students = File.ReadAllLines(diag.FileName);
        var newStudents = new List<StudentData>();
        foreach (var student in students)
        {
            var split = student.Split(',');
            if (split.Length != 2) continue;
            newStudents.Add(new StudentData
            {
                name = split[0].Replace(CommaEscape, ","),
                units = split[1].Split(';').Select(s => s.Replace(SemiEscape, ";")).ToList()
            });
        }

        _persistentData.Students.AddRange(newStudents);
        ResetStudentsListBox();
        _persistentData.Save(FileName);
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var diag = new SaveFileDialog
        {
            Filter = @"CSV Files|*.csv",
            Title = @"Export Students"
        };
        if (diag.ShowDialog() != DialogResult.OK) return;
        var students = _persistentData.Students.Select(s => $"{s.name.Replace(",", CommaEscape)},{string.Join(";", s.units.Select(u => u.Replace(";", SemiEscape)))}");
        File.WriteAllLines(diag.FileName, students);
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(@"This will clear all students, are you sure?", @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
        _persistentData.Students.Clear();
        ResetStudentsListBox();
    }

    private void btnSwitchSession_Click(object sender, EventArgs e)
    {
        _persistentData.CurrentSession = _persistentData.CurrentSession == Session.AM ? Session.PM : Session.AM;
        btnSwitchSession.Text = $"Switch To {_persistentData.CurrentSession}";
        ResetStudentsListBox();
    }

    private void btnAddStudent_Click(object sender, EventArgs e)
    {
        var student = new StudentData
        {
            name = "New Student",
            units = new List<string>()
        };
        _persistentData.Students.Add(student);
        ResetStudentsListBox();
    }

    private void btnRemoveStudent_Click(object sender, EventArgs e)
    {
        if (lstStudents.SelectedIndex < 0) return;
        _persistentData.Students.RemoveAt(lstStudents.SelectedIndex);
        ResetStudentsListBox();
    }

    private void ShowStudent(StudentData student)
    {
        grpActiveStudent.Visible = true;
        txtStudentName.Text = student.name;
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(student.units.ToArray());
    }

    private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstStudents.SelectedItem is StudentData data)
            ShowStudent(data);
        else
            grpActiveStudent.Visible = false;
    }

    private void txtStudentName_TextChanged(object sender, EventArgs e)
    {
        if (lstStudents.SelectedItem is StudentData) _persistentData.Students[lstStudents.SelectedIndex].name = txtStudentName.Text;

        lstStudents.Items[lstStudents.SelectedIndex] = _persistentData.Students[lstStudents.SelectedIndex];
    }

    private void btnAddStudentUnit_Click(object sender, EventArgs e)
    {
        if (lstUnits.SelectedIndex < 0)
        {
            MessageBox.Show("Please select a unit to add the student to", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_persistentData.Students[lstStudents.SelectedIndex].units.Exists(s => s == lstUnits.SelectedItem.ToString()))
        {
            MessageBox.Show("The student was already in this unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _persistentData.Students[lstStudents.SelectedIndex].units.Add(lstUnits.SelectedItem.ToString());
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(_persistentData.Students[lstStudents.SelectedIndex].units.ToArray());
        ShowUnit(_persistentData.Units[lstUnits.SelectedIndex]);
    }

    private void btnRemoveStudentFromUnit_Click(object sender, EventArgs e)
    {
        if (lstStudentUnits.SelectedIndex < 0) return;
        _persistentData.Students[lstStudents.SelectedIndex].units.RemoveAt(lstStudentUnits.SelectedIndex);
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(_persistentData.Students[lstStudents.SelectedIndex].units.ToArray());
    }

    #endregion
}