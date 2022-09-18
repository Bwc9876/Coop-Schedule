using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CoopSchedule.External;

namespace CoopSchedule;

public partial class CoopForm : Form
{
    private const string FileName = "data.json";
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

        var previousUnits = _persistentData.Students.Select(s => { return s.Units.Select(u => _persistentData.Units.FindIndex(u2 => u2.Name == u)).ToArray(); });

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
            _persistentData.Students[(int) i].Units.AddRange(
                newTable[i].Select(
                    u => unitNames[(int) Math.Log(u, 2)]
                )
            );

        _persistentData.Save(FileName);

        ResetStudentsListBox();

        ScheduleHandler.OutputTable(
            newTable,
            _persistentData.Students.Select(s => s.Name).ToArray(),
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
        _persistentData.Students.ForEach(s => s.Units.Clear());
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
        if (lstStudents.SelectedIndex != -1)
        {
            lstStudentUnits.Items.Clear();
            lstStudentUnits.Items.AddRange(_persistentData.Students[lstStudents.SelectedIndex].Units.ToArray());
        }
    }

    private void btnAddStudent_Click(object sender, EventArgs e)
    {
        var student = new StudentData
        {
            Name = "New Student",
            Units = new List<string>()
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
        txtStudentName.Text = student.Name;
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(student.Units.ToArray());
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
        if (lstStudents.SelectedItem is StudentData) _persistentData.Students[lstStudents.SelectedIndex].Name = txtStudentName.Text;

        lstStudents.Items[lstStudents.SelectedIndex] = _persistentData.Students[lstStudents.SelectedIndex];
    }

    private void btnRemoveStudentFromUnit_Click(object sender, EventArgs e)
    {
        if (lstStudentUnits.SelectedIndex < 0) return;
        _persistentData.Students[lstStudents.SelectedIndex].Units.RemoveAt(lstStudentUnits.SelectedIndex);
        lstStudentUnits.Items.Clear();
        lstStudentUnits.Items.AddRange(_persistentData.Students[lstStudents.SelectedIndex].Units.ToArray());
    }

    #endregion
}