namespace CoopSchedule
{
    partial class CoopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.btnRemoveUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.grpActiveUnit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitStudents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.grpActiveStudent = new System.Windows.Forms.GroupBox();
            this.btnRemoveStudentFromUnit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstStudentUnits = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.grpGenerate = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDays = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStudentUnitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUnits.SuspendLayout();
            this.grpActiveUnit.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.grpActiveStudent.SuspendLayout();
            this.grpGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numDays)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.btnRemoveUnit);
            this.grpUnits.Controls.Add(this.btnAddUnit);
            this.grpUnits.Controls.Add(this.grpActiveUnit);
            this.grpUnits.Controls.Add(this.lstUnits);
            this.grpUnits.Location = new System.Drawing.Point(12, 36);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(355, 209);
            this.grpUnits.TabIndex = 0;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Units";
            // 
            // btnRemoveUnit
            // 
            this.btnRemoveUnit.Location = new System.Drawing.Point(132, 168);
            this.btnRemoveUnit.Name = "btnRemoveUnit";
            this.btnRemoveUnit.Size = new System.Drawing.Size(217, 24);
            this.btnRemoveUnit.TabIndex = 3;
            this.btnRemoveUnit.Text = "Remove Unit";
            this.btnRemoveUnit.UseVisualStyleBackColor = true;
            this.btnRemoveUnit.Click += new System.EventHandler(this.btnRemoveUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(132, 130);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(217, 32);
            this.btnAddUnit.TabIndex = 2;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // grpActiveUnit
            // 
            this.grpActiveUnit.Controls.Add(this.label2);
            this.grpActiveUnit.Controls.Add(this.txtUnitStudents);
            this.grpActiveUnit.Controls.Add(this.label1);
            this.grpActiveUnit.Controls.Add(this.txtUnitName);
            this.grpActiveUnit.Location = new System.Drawing.Point(132, 19);
            this.grpActiveUnit.Name = "grpActiveUnit";
            this.grpActiveUnit.Size = new System.Drawing.Size(217, 105);
            this.grpActiveUnit.TabIndex = 1;
            this.grpActiveUnit.TabStop = false;
            this.grpActiveUnit.Text = "Edit";
            this.grpActiveUnit.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Of Students";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitStudents
            // 
            this.txtUnitStudents.Location = new System.Drawing.Point(102, 68);
            this.txtUnitStudents.Name = "txtUnitStudents";
            this.txtUnitStudents.Size = new System.Drawing.Size(94, 20);
            this.txtUnitStudents.TabIndex = 2;
            this.txtUnitStudents.TextChanged += new System.EventHandler(this.txtUnitStudents_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(102, 31);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(94, 20);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            // 
            // lstUnits
            // 
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(6, 19);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(120, 173);
            this.lstUnits.TabIndex = 0;
            this.lstUnits.SelectedIndexChanged += new System.EventHandler(this.lstUnits_SelectedIndexChanged);
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.btnRemoveStudent);
            this.grpStudents.Controls.Add(this.grpActiveStudent);
            this.grpStudents.Controls.Add(this.btnAddStudent);
            this.grpStudents.Controls.Add(this.lstStudents);
            this.grpStudents.Location = new System.Drawing.Point(373, 36);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(363, 306);
            this.grpStudents.TabIndex = 1;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students";
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(132, 272);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(217, 24);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // grpActiveStudent
            // 
            this.grpActiveStudent.Controls.Add(this.btnRemoveStudentFromUnit);
            this.grpActiveStudent.Controls.Add(this.label4);
            this.grpActiveStudent.Controls.Add(this.lstStudentUnits);
            this.grpActiveStudent.Controls.Add(this.label3);
            this.grpActiveStudent.Controls.Add(this.txtStudentName);
            this.grpActiveStudent.Location = new System.Drawing.Point(138, 19);
            this.grpActiveStudent.Name = "grpActiveStudent";
            this.grpActiveStudent.Size = new System.Drawing.Size(211, 204);
            this.grpActiveStudent.TabIndex = 1;
            this.grpActiveStudent.TabStop = false;
            this.grpActiveStudent.Text = "Edit";
            this.grpActiveStudent.Visible = false;
            // 
            // btnRemoveStudentFromUnit
            // 
            this.btnRemoveStudentFromUnit.Location = new System.Drawing.Point(21, 167);
            this.btnRemoveStudentFromUnit.Name = "btnRemoveStudentFromUnit";
            this.btnRemoveStudentFromUnit.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveStudentFromUnit.TabIndex = 8;
            this.btnRemoveStudentFromUnit.Text = "Remove";
            this.btnRemoveStudentFromUnit.UseVisualStyleBackColor = true;
            this.btnRemoveStudentFromUnit.Click += new System.EventHandler(this.btnRemoveStudentFromUnit_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Previous Units";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstStudentUnits
            // 
            this.lstStudentUnits.FormattingEnabled = true;
            this.lstStudentUnits.Location = new System.Drawing.Point(102, 82);
            this.lstStudentUnits.Name = "lstStudentUnits";
            this.lstStudentUnits.Size = new System.Drawing.Size(94, 108);
            this.lstStudentUnits.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(102, 28);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(94, 20);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(132, 229);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(217, 37);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(6, 19);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(120, 277);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // grpGenerate
            // 
            this.grpGenerate.Controls.Add(this.btnGenerate);
            this.grpGenerate.Controls.Add(this.lblDays);
            this.grpGenerate.Controls.Add(this.numDays);
            this.grpGenerate.Location = new System.Drawing.Point(12, 251);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(355, 91);
            this.grpGenerate.TabIndex = 2;
            this.grpGenerate.TabStop = false;
            this.grpGenerate.Text = "Generate";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(185, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 53);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(6, 35);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(90, 20);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "Number Of Days";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(102, 37);
            this.numDays.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numDays.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(74, 20);
            this.numDays.TabIndex = 3;
            this.numDays.Value = new decimal(new int[] {4, 0, 0, 0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.saveToolStripMenuItem, this.resetStudentUnitsToolStripMenuItem, this.resetAllToolStripMenuItem, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetStudentUnitsToolStripMenuItem
            // 
            this.resetStudentUnitsToolStripMenuItem.Name = "resetStudentUnitsToolStripMenuItem";
            this.resetStudentUnitsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetStudentUnitsToolStripMenuItem.Text = "Reset Student Units";
            this.resetStudentUnitsToolStripMenuItem.Click += new System.EventHandler(this.resetStudentUnitsToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 350);
            this.Controls.Add(this.grpGenerate);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpUnits);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoopForm";
            this.ShowIcon = false;
            this.Text = "Co-Op Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoopForm_FormClosing);
            this.Load += new System.EventHandler(this.CoopForm_Load);
            this.grpUnits.ResumeLayout(false);
            this.grpActiveUnit.ResumeLayout(false);
            this.grpActiveUnit.PerformLayout();
            this.grpStudents.ResumeLayout(false);
            this.grpActiveStudent.ResumeLayout(false);
            this.grpActiveStudent.PerformLayout();
            this.grpGenerate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numDays)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStudentUnitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.GroupBox grpGenerate;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button btnGenerate;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ListBox lstStudentUnits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveStudentFromUnit;

        private System.Windows.Forms.GroupBox grpActiveStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnAddStudent;

        private System.Windows.Forms.ListBox lstStudents;

        private System.Windows.Forms.GroupBox grpStudents;

        private System.Windows.Forms.Button btnRemoveUnit;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitStudents;

        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnAddUnit;

        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.ListBox lstUnits;
        private System.Windows.Forms.GroupBox grpActiveUnit;

        #endregion
    }
}