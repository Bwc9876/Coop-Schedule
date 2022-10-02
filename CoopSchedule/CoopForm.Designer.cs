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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoopForm));
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.btnRemoveUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.grpActiveUnit = new System.Windows.Forms.GroupBox();
            this.lblCyclesLeft = new System.Windows.Forms.Label();
            this.lblCyclesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitStudents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.lstUnits = new System.Windows.Forms.ListBox();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.btnSwitchSession = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.grpActiveStudent = new System.Windows.Forms.GroupBox();
            this.btnAddStudentUnit = new System.Windows.Forms.Button();
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
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.grpUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUnits.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpUnits.Location = new System.Drawing.Point(12, 42);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(355, 270);
            this.grpUnits.TabIndex = 0;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Units";
            // 
            // btnRemoveUnit
            // 
            this.btnRemoveUnit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRemoveUnit.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnRemoveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUnit.Image = ((System.Drawing.Image) (resources.GetObject("btnRemoveUnit.Image")));
            this.btnRemoveUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveUnit.Location = new System.Drawing.Point(132, 224);
            this.btnRemoveUnit.Name = "btnRemoveUnit";
            this.btnRemoveUnit.Size = new System.Drawing.Size(217, 35);
            this.btnRemoveUnit.TabIndex = 3;
            this.btnRemoveUnit.Text = "Remove Unit";
            this.btnRemoveUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveUnit.UseVisualStyleBackColor = false;
            this.btnRemoveUnit.Click += new System.EventHandler(this.btnRemoveUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddUnit.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Image = ((System.Drawing.Image) (resources.GetObject("btnAddUnit.Image")));
            this.btnAddUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUnit.Location = new System.Drawing.Point(132, 177);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(217, 41);
            this.btnAddUnit.TabIndex = 2;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // grpActiveUnit
            // 
            this.grpActiveUnit.Controls.Add(this.lblCyclesLeft);
            this.grpActiveUnit.Controls.Add(this.lblCyclesLabel);
            this.grpActiveUnit.Controls.Add(this.label2);
            this.grpActiveUnit.Controls.Add(this.txtUnitStudents);
            this.grpActiveUnit.Controls.Add(this.label1);
            this.grpActiveUnit.Controls.Add(this.txtUnitName);
            this.grpActiveUnit.Location = new System.Drawing.Point(132, 19);
            this.grpActiveUnit.Name = "grpActiveUnit";
            this.grpActiveUnit.Size = new System.Drawing.Size(217, 152);
            this.grpActiveUnit.TabIndex = 1;
            this.grpActiveUnit.TabStop = false;
            this.grpActiveUnit.Text = "Edit";
            this.grpActiveUnit.Visible = false;
            // 
            // lblCyclesLeft
            // 
            this.lblCyclesLeft.Location = new System.Drawing.Point(102, 115);
            this.lblCyclesLeft.Name = "lblCyclesLeft";
            this.lblCyclesLeft.Size = new System.Drawing.Size(94, 20);
            this.lblCyclesLeft.TabIndex = 5;
            this.lblCyclesLeft.Text = "0";
            this.lblCyclesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCyclesLabel
            // 
            this.lblCyclesLabel.Location = new System.Drawing.Point(6, 115);
            this.lblCyclesLabel.Name = "lblCyclesLabel";
            this.lblCyclesLabel.Size = new System.Drawing.Size(90, 20);
            this.lblCyclesLabel.TabIndex = 4;
            this.lblCyclesLabel.Text = "Cycles Left";
            this.lblCyclesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Of Students";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitStudents
            // 
            this.txtUnitStudents.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUnitStudents.Location = new System.Drawing.Point(102, 67);
            this.txtUnitStudents.Name = "txtUnitStudents";
            this.txtUnitStudents.Size = new System.Drawing.Size(94, 22);
            this.txtUnitStudents.TabIndex = 2;
            this.txtUnitStudents.TextChanged += new System.EventHandler(this.txtUnitStudents_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUnitName
            // 
            this.txtUnitName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtUnitName.Location = new System.Drawing.Point(102, 39);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(94, 22);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.TextChanged += new System.EventHandler(this.txtUnitName_TextChanged);
            // 
            // lstUnits
            // 
            this.lstUnits.BackColor = System.Drawing.Color.GhostWhite;
            this.lstUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUnits.FormattingEnabled = true;
            this.lstUnits.Location = new System.Drawing.Point(6, 19);
            this.lstUnits.Name = "lstUnits";
            this.lstUnits.Size = new System.Drawing.Size(120, 234);
            this.lstUnits.TabIndex = 0;
            this.lstUnits.SelectedIndexChanged += new System.EventHandler(this.lstUnits_SelectedIndexChanged);
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.btnSwitchSession);
            this.grpStudents.Controls.Add(this.btnRemoveStudent);
            this.grpStudents.Controls.Add(this.grpActiveStudent);
            this.grpStudents.Controls.Add(this.btnAddStudent);
            this.grpStudents.Controls.Add(this.lstStudents);
            this.grpStudents.Location = new System.Drawing.Point(373, 42);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(363, 376);
            this.grpStudents.TabIndex = 1;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students";
            // 
            // btnSwitchSession
            // 
            this.btnSwitchSession.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSwitchSession.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnSwitchSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchSession.Image = ((System.Drawing.Image) (resources.GetObject("btnSwitchSession.Image")));
            this.btnSwitchSession.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSwitchSession.Location = new System.Drawing.Point(14, 19);
            this.btnSwitchSession.Name = "btnSwitchSession";
            this.btnSwitchSession.Size = new System.Drawing.Size(120, 35);
            this.btnSwitchSession.TabIndex = 4;
            this.btnSwitchSession.Text = "Switch To PM";
            this.btnSwitchSession.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSwitchSession.UseVisualStyleBackColor = false;
            this.btnSwitchSession.Click += new System.EventHandler(this.btnSwitchSession_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRemoveStudent.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.Image = ((System.Drawing.Image) (resources.GetObject("btnRemoveStudent.Image")));
            this.btnRemoveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveStudent.Location = new System.Drawing.Point(140, 327);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(217, 37);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // grpActiveStudent
            // 
            this.grpActiveStudent.Controls.Add(this.btnAddStudentUnit);
            this.grpActiveStudent.Controls.Add(this.btnRemoveStudentFromUnit);
            this.grpActiveStudent.Controls.Add(this.label4);
            this.grpActiveStudent.Controls.Add(this.lstStudentUnits);
            this.grpActiveStudent.Controls.Add(this.label3);
            this.grpActiveStudent.Controls.Add(this.txtStudentName);
            this.grpActiveStudent.Location = new System.Drawing.Point(146, 19);
            this.grpActiveStudent.Name = "grpActiveStudent";
            this.grpActiveStudent.Size = new System.Drawing.Size(211, 251);
            this.grpActiveStudent.TabIndex = 1;
            this.grpActiveStudent.TabStop = false;
            this.grpActiveStudent.Text = "Edit";
            this.grpActiveStudent.Visible = false;
            // 
            // btnAddStudentUnit
            // 
            this.btnAddStudentUnit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddStudentUnit.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnAddStudentUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudentUnit.Image = ((System.Drawing.Image) (resources.GetObject("btnAddStudentUnit.Image")));
            this.btnAddStudentUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudentUnit.Location = new System.Drawing.Point(21, 167);
            this.btnAddStudentUnit.Name = "btnAddStudentUnit";
            this.btnAddStudentUnit.Size = new System.Drawing.Size(75, 32);
            this.btnAddStudentUnit.TabIndex = 9;
            this.btnAddStudentUnit.Text = "Add";
            this.btnAddStudentUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudentUnit.UseVisualStyleBackColor = false;
            this.btnAddStudentUnit.Click += new System.EventHandler(this.btnAddStudentUnit_Click);
            // 
            // btnRemoveStudentFromUnit
            // 
            this.btnRemoveStudentFromUnit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRemoveStudentFromUnit.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnRemoveStudentFromUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudentFromUnit.Image = ((System.Drawing.Image) (resources.GetObject("btnRemoveStudentFromUnit.Image")));
            this.btnRemoveStudentFromUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveStudentFromUnit.Location = new System.Drawing.Point(21, 211);
            this.btnRemoveStudentFromUnit.Name = "btnRemoveStudentFromUnit";
            this.btnRemoveStudentFromUnit.Size = new System.Drawing.Size(75, 32);
            this.btnRemoveStudentFromUnit.TabIndex = 8;
            this.btnRemoveStudentFromUnit.Text = "Remove";
            this.btnRemoveStudentFromUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveStudentFromUnit.UseVisualStyleBackColor = false;
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
            this.lstStudentUnits.BackColor = System.Drawing.Color.GhostWhite;
            this.lstStudentUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStudentUnits.FormattingEnabled = true;
            this.lstStudentUnits.Location = new System.Drawing.Point(102, 82);
            this.lstStudentUnits.Name = "lstStudentUnits";
            this.lstStudentUnits.Size = new System.Drawing.Size(94, 156);
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
            this.txtStudentName.BackColor = System.Drawing.Color.GhostWhite;
            this.txtStudentName.Location = new System.Drawing.Point(102, 28);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(94, 22);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.TextChanged += new System.EventHandler(this.txtStudentName_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Image = ((System.Drawing.Image) (resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStudent.Location = new System.Drawing.Point(140, 276);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(217, 45);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.BackColor = System.Drawing.Color.GhostWhite;
            this.lstStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(14, 68);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(120, 299);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // grpGenerate
            // 
            this.grpGenerate.Controls.Add(this.btnGenerate);
            this.grpGenerate.Controls.Add(this.lblDays);
            this.grpGenerate.Controls.Add(this.numDays);
            this.grpGenerate.Location = new System.Drawing.Point(12, 318);
            this.grpGenerate.Name = "grpGenerate";
            this.grpGenerate.Size = new System.Drawing.Size(355, 100);
            this.grpGenerate.TabIndex = 2;
            this.grpGenerate.TabStop = false;
            this.grpGenerate.Text = "Generate";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.Thistle;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Image = ((System.Drawing.Image) (resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.Location = new System.Drawing.Point(175, 27);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(164, 53);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate!";
            this.btnGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(16, 45);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(63, 22);
            this.lblDays.TabIndex = 4;
            this.lblDays.Text = "# Of Days";
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDays
            // 
            this.numDays.BackColor = System.Drawing.Color.GhostWhite;
            this.numDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDays.Location = new System.Drawing.Point(85, 45);
            this.numDays.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numDays.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(74, 22);
            this.numDays.TabIndex = 3;
            this.numDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDays.Value = new decimal(new int[] {4, 0, 0, 0});
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem, this.studentsToolStripMenuItem, this.unitsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.saveToolStripMenuItem, this.resetStudentUnitsToolStripMenuItem, this.resetAllToolStripMenuItem, this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // resetStudentUnitsToolStripMenuItem
            // 
            this.resetStudentUnitsToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.resetStudentUnitsToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("resetStudentUnitsToolStripMenuItem.Image")));
            this.resetStudentUnitsToolStripMenuItem.Name = "resetStudentUnitsToolStripMenuItem";
            this.resetStudentUnitsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.resetStudentUnitsToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.resetStudentUnitsToolStripMenuItem.Text = "Reset Student Units";
            this.resetStudentUnitsToolStripMenuItem.Click += new System.EventHandler(this.resetStudentUnitsToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.resetAllToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("resetAllToolStripMenuItem.Image")));
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.importToolStripMenuItem, this.exportToolStripMenuItem, this.clearToolStripMenuItem});
            this.studentsToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("studentsToolStripMenuItem.Image")));
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.importToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.importToolStripMenuItem1, this.exportToolStripMenuItem1, this.clearToolStripMenuItem1});
            this.unitsToolStripMenuItem.Image = ((System.Drawing.Image) (resources.GetObject("unitsToolStripMenuItem.Image")));
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.unitsToolStripMenuItem.Text = "Units";
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue;
            this.importToolStripMenuItem1.Image = ((System.Drawing.Image) (resources.GetObject("importToolStripMenuItem1.Image")));
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.importToolStripMenuItem1.Text = "Import";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue;
            this.exportToolStripMenuItem1.Image = ((System.Drawing.Image) (resources.GetObject("exportToolStripMenuItem1.Image")));
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue;
            this.clearToolStripMenuItem1.Image = ((System.Drawing.Image) (resources.GetObject("clearToolStripMenuItem1.Image")));
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // CoopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(743, 440);
            this.Controls.Add(this.grpGenerate);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpUnits);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "CoopForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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

        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;

        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;

        private System.Windows.Forms.Button btnSwitchSession;

        private System.Windows.Forms.Label lblCyclesLabel;
        private System.Windows.Forms.Label lblCyclesLeft;

        private System.Windows.Forms.Button btnAddStudentUnit;

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