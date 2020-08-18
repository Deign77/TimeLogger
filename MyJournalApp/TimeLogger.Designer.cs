namespace TimeLogger
{
    partial class TimeLogger
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAchievements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalendartoGrid = new System.Windows.Forms.Button();
            this.pnlNewEntry = new System.Windows.Forms.Panel();
            this.lblActivity = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEditEntry = new System.Windows.Forms.Button();
            this.txtbxComments = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxHours = new System.Windows.Forms.TextBox();
            this.txtbxActivity = new System.Windows.Forms.TextBox();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.txtbxAchievements = new System.Windows.Forms.TextBox();
            this.pnlMonths = new System.Windows.Forms.Panel();
            this.btnYear4 = new System.Windows.Forms.Button();
            this.btnYear5 = new System.Windows.Forms.Button();
            this.btnYear2 = new System.Windows.Forms.Button();
            this.btnYear3 = new System.Windows.Forms.Button();
            this.btnYear1 = new System.Windows.Forms.Button();
            this.lblNoData = new System.Windows.Forms.Label();
            this.btnFebruary = new System.Windows.Forms.Button();
            this.btnMarch = new System.Windows.Forms.Button();
            this.btnApril = new System.Windows.Forms.Button();
            this.btnSeptember = new System.Windows.Forms.Button();
            this.btnMay = new System.Windows.Forms.Button();
            this.btnNovember = new System.Windows.Forms.Button();
            this.btnDecember = new System.Windows.Forms.Button();
            this.btnOctober = new System.Windows.Forms.Button();
            this.btnJune = new System.Windows.Forms.Button();
            this.btnJuly = new System.Windows.Forms.Button();
            this.btnAugust = new System.Windows.Forms.Button();
            this.btnJanuary = new System.Windows.Forms.Button();
            this.lblEditedEntries = new System.Windows.Forms.Label();
            this.lblDeletedEntries = new System.Windows.Forms.Label();
            this.lblSavedEntries = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnNewEntrytoStats = new System.Windows.Forms.Button();
            this.lblStatsFor = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblOverallBestDayDisplay = new System.Windows.Forms.Label();
            this.btnSearchbyActivity = new System.Windows.Forms.Button();
            this.lblTotalActivitiesDisplay = new System.Windows.Forms.Label();
            this.lblHoursWorkedDisplay = new System.Windows.Forms.Label();
            this.lblAverageHoursDisplay = new System.Windows.Forms.Label();
            this.lblDaysWorkedDisplay = new System.Windows.Forms.Label();
            this.lblMonthsWorkedDisplay = new System.Windows.Forms.Label();
            this.txtbxProjectSearch = new System.Windows.Forms.TextBox();
            this.lblTotalActivities = new System.Windows.Forms.Label();
            this.lblMonthsWorked = new System.Windows.Forms.Label();
            this.lblBestDayOverall = new System.Windows.Forms.Label();
            this.lblDaysWorked = new System.Windows.Forms.Label();
            this.lblTotalHoursWorked = new System.Windows.Forms.Label();
            this.lblAverageHours = new System.Windows.Forms.Label();
            this.lblSelectionDaysWorkedDisplay = new System.Windows.Forms.Label();
            this.lblSelectionDaysWorked = new System.Windows.Forms.Label();
            this.lblSelectionBestDay = new System.Windows.Forms.Label();
            this.lblStatsForActivity = new System.Windows.Forms.Label();
            this.cmbxMostActive = new System.Windows.Forms.ComboBox();
            this.lblSelectionHoursWorkedDisplay = new System.Windows.Forms.Label();
            this.lblSelectionBestDayDisplay = new System.Windows.Forms.Label();
            this.lblSelectionHoursWorked = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewSaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSelectSearch = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlNewEntry.SuspendLayout();
            this.pnlMonths.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.pnlSelectSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEntry.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeleteEntry.FlatAppearance.BorderSize = 4;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntry.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteEntry.Location = new System.Drawing.Point(202, 80);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(86, 58);
            this.btnDeleteEntry.TabIndex = 3;
            this.btnDeleteEntry.Text = "Delete";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmActivity,
            this.clmHours,
            this.clmAchievements,
            this.clmComments});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Location = new System.Drawing.Point(12, 36);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv.Size = new System.Drawing.Size(850, 440);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmActivity
            // 
            this.clmActivity.HeaderText = "Activity";
            this.clmActivity.Name = "clmActivity";
            this.clmActivity.ReadOnly = true;
            this.clmActivity.Width = 185;
            // 
            // clmHours
            // 
            this.clmHours.HeaderText = "Hours";
            this.clmHours.Name = "clmHours";
            this.clmHours.ReadOnly = true;
            this.clmHours.Width = 85;
            // 
            // clmAchievements
            // 
            this.clmAchievements.HeaderText = "Achievements";
            this.clmAchievements.Name = "clmAchievements";
            this.clmAchievements.ReadOnly = true;
            this.clmAchievements.Width = 200;
            // 
            // clmComments
            // 
            this.clmComments.HeaderText = "Comments";
            this.clmComments.Name = "clmComments";
            this.clmComments.ReadOnly = true;
            this.clmComments.Width = 270;
            // 
            // btnCalendartoGrid
            // 
            this.btnCalendartoGrid.BackColor = System.Drawing.Color.DarkGray;
            this.btnCalendartoGrid.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCalendartoGrid.FlatAppearance.BorderSize = 4;
            this.btnCalendartoGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendartoGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendartoGrid.Location = new System.Drawing.Point(314, 476);
            this.btnCalendartoGrid.Name = "btnCalendartoGrid";
            this.btnCalendartoGrid.Size = new System.Drawing.Size(250, 43);
            this.btnCalendartoGrid.TabIndex = 6;
            this.btnCalendartoGrid.Text = "Calendar";
            this.btnCalendartoGrid.UseVisualStyleBackColor = false;
            this.btnCalendartoGrid.Click += new System.EventHandler(this.btnshowmonths_Click);
            // 
            // pnlNewEntry
            // 
            this.pnlNewEntry.BackColor = System.Drawing.Color.DarkGray;
            this.pnlNewEntry.Controls.Add(this.lblActivity);
            this.pnlNewEntry.Controls.Add(this.btnDate);
            this.pnlNewEntry.Controls.Add(this.btnClear);
            this.pnlNewEntry.Controls.Add(this.btnEditEntry);
            this.pnlNewEntry.Controls.Add(this.txtbxComments);
            this.pnlNewEntry.Controls.Add(this.btnSave);
            this.pnlNewEntry.Controls.Add(this.btnDeleteEntry);
            this.pnlNewEntry.Controls.Add(this.txtbxHours);
            this.pnlNewEntry.Controls.Add(this.txtbxActivity);
            this.pnlNewEntry.Controls.Add(this.txtbxDate);
            this.pnlNewEntry.Controls.Add(this.lblComments);
            this.pnlNewEntry.Controls.Add(this.lblHours);
            this.pnlNewEntry.Controls.Add(this.lblAchievements);
            this.pnlNewEntry.Controls.Add(this.txtbxAchievements);
            this.pnlNewEntry.Location = new System.Drawing.Point(12, 560);
            this.pnlNewEntry.Name = "pnlNewEntry";
            this.pnlNewEntry.Size = new System.Drawing.Size(850, 170);
            this.pnlNewEntry.TabIndex = 7;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.BackColor = System.Drawing.Color.DarkGray;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(111, 19);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(62, 16);
            this.lblActivity.TabIndex = 14;
            this.lblActivity.Text = "Activity:";
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.DarkGray;
            this.btnDate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDate.FlatAppearance.BorderSize = 3;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.Location = new System.Drawing.Point(14, 12);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(62, 30);
            this.btnDate.TabIndex = 12;
            this.btnDate.Text = "Date:";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 4;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(295, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 58);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEditEntry
            // 
            this.btnEditEntry.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditEntry.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditEntry.FlatAppearance.BorderSize = 4;
            this.btnEditEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEntry.ForeColor = System.Drawing.Color.Gold;
            this.btnEditEntry.Location = new System.Drawing.Point(108, 80);
            this.btnEditEntry.Name = "btnEditEntry";
            this.btnEditEntry.Size = new System.Drawing.Size(86, 58);
            this.btnEditEntry.TabIndex = 10;
            this.btnEditEntry.Text = "Edit";
            this.btnEditEntry.UseVisualStyleBackColor = false;
            this.btnEditEntry.Click += new System.EventHandler(this.btnEditEntry_Click);
            // 
            // txtbxComments
            // 
            this.txtbxComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxComments.Location = new System.Drawing.Point(584, 44);
            this.txtbxComments.Multiline = true;
            this.txtbxComments.Name = "txtbxComments";
            this.txtbxComments.Size = new System.Drawing.Size(254, 94);
            this.txtbxComments.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 4;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Green;
            this.btnSave.Location = new System.Drawing.Point(14, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 58);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtbxHours
            // 
            this.txtbxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxHours.Location = new System.Drawing.Point(305, 44);
            this.txtbxHours.Name = "txtbxHours";
            this.txtbxHours.Size = new System.Drawing.Size(57, 21);
            this.txtbxHours.TabIndex = 7;
            // 
            // txtbxActivity
            // 
            this.txtbxActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxActivity.Location = new System.Drawing.Point(114, 44);
            this.txtbxActivity.Name = "txtbxActivity";
            this.txtbxActivity.Size = new System.Drawing.Size(184, 21);
            this.txtbxActivity.TabIndex = 6;
            // 
            // txtbxDate
            // 
            this.txtbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDate.Location = new System.Drawing.Point(14, 44);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.Size = new System.Drawing.Size(93, 21);
            this.txtbxDate.TabIndex = 5;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(581, 19);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(84, 16);
            this.lblComments.TabIndex = 4;
            this.lblComments.Text = "Comments:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.DarkGray;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(302, 19);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(53, 16);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours:";
            // 
            // lblAchievements
            // 
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.BackColor = System.Drawing.Color.DarkGray;
            this.lblAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchievements.Location = new System.Drawing.Point(367, 19);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(109, 16);
            this.lblAchievements.TabIndex = 1;
            this.lblAchievements.Text = "Achievements:";
            // 
            // txtbxAchievements
            // 
            this.txtbxAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAchievements.Location = new System.Drawing.Point(370, 44);
            this.txtbxAchievements.Multiline = true;
            this.txtbxAchievements.Name = "txtbxAchievements";
            this.txtbxAchievements.Size = new System.Drawing.Size(208, 94);
            this.txtbxAchievements.TabIndex = 8;
            // 
            // pnlMonths
            // 
            this.pnlMonths.BackColor = System.Drawing.Color.Maroon;
            this.pnlMonths.Controls.Add(this.btnYear4);
            this.pnlMonths.Controls.Add(this.btnYear5);
            this.pnlMonths.Controls.Add(this.btnYear2);
            this.pnlMonths.Controls.Add(this.btnYear3);
            this.pnlMonths.Controls.Add(this.btnYear1);
            this.pnlMonths.Controls.Add(this.lblNoData);
            this.pnlMonths.Controls.Add(this.btnFebruary);
            this.pnlMonths.Controls.Add(this.btnMarch);
            this.pnlMonths.Controls.Add(this.btnApril);
            this.pnlMonths.Controls.Add(this.btnSeptember);
            this.pnlMonths.Controls.Add(this.btnMay);
            this.pnlMonths.Controls.Add(this.btnNovember);
            this.pnlMonths.Controls.Add(this.btnDecember);
            this.pnlMonths.Controls.Add(this.btnOctober);
            this.pnlMonths.Controls.Add(this.btnJune);
            this.pnlMonths.Controls.Add(this.btnJuly);
            this.pnlMonths.Controls.Add(this.btnAugust);
            this.pnlMonths.Controls.Add(this.btnJanuary);
            this.pnlMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMonths.Location = new System.Drawing.Point(12, 36);
            this.pnlMonths.Name = "pnlMonths";
            this.pnlMonths.Size = new System.Drawing.Size(850, 440);
            this.pnlMonths.TabIndex = 8;
            this.pnlMonths.Visible = false;
            // 
            // btnYear4
            // 
            this.btnYear4.BackColor = System.Drawing.Color.DarkGray;
            this.btnYear4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnYear4.FlatAppearance.BorderSize = 4;
            this.btnYear4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear4.Location = new System.Drawing.Point(510, 22);
            this.btnYear4.Name = "btnYear4";
            this.btnYear4.Size = new System.Drawing.Size(120, 60);
            this.btnYear4.TabIndex = 20;
            this.btnYear4.Text = "Year4";
            this.btnYear4.UseVisualStyleBackColor = false;
            this.btnYear4.Visible = false;
            this.btnYear4.Click += new System.EventHandler(this.YearButtonClick);
            // 
            // btnYear5
            // 
            this.btnYear5.BackColor = System.Drawing.Color.DarkGray;
            this.btnYear5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnYear5.FlatAppearance.BorderSize = 4;
            this.btnYear5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear5.Location = new System.Drawing.Point(670, 22);
            this.btnYear5.Name = "btnYear5";
            this.btnYear5.Size = new System.Drawing.Size(120, 60);
            this.btnYear5.TabIndex = 19;
            this.btnYear5.Text = "Year5";
            this.btnYear5.UseVisualStyleBackColor = false;
            this.btnYear5.Visible = false;
            this.btnYear5.Click += new System.EventHandler(this.YearButtonClick);
            // 
            // btnYear2
            // 
            this.btnYear2.BackColor = System.Drawing.Color.DarkGray;
            this.btnYear2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnYear2.FlatAppearance.BorderSize = 4;
            this.btnYear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear2.Location = new System.Drawing.Point(190, 20);
            this.btnYear2.Name = "btnYear2";
            this.btnYear2.Size = new System.Drawing.Size(120, 60);
            this.btnYear2.TabIndex = 18;
            this.btnYear2.Text = "Year2";
            this.btnYear2.UseVisualStyleBackColor = false;
            this.btnYear2.Visible = false;
            this.btnYear2.Click += new System.EventHandler(this.YearButtonClick);
            // 
            // btnYear3
            // 
            this.btnYear3.BackColor = System.Drawing.Color.DarkGray;
            this.btnYear3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnYear3.FlatAppearance.BorderSize = 4;
            this.btnYear3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear3.Location = new System.Drawing.Point(350, 22);
            this.btnYear3.Name = "btnYear3";
            this.btnYear3.Size = new System.Drawing.Size(120, 60);
            this.btnYear3.TabIndex = 17;
            this.btnYear3.Text = "Year3";
            this.btnYear3.UseVisualStyleBackColor = false;
            this.btnYear3.Visible = false;
            this.btnYear3.Click += new System.EventHandler(this.YearButtonClick);
            // 
            // btnYear1
            // 
            this.btnYear1.BackColor = System.Drawing.Color.DarkGray;
            this.btnYear1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnYear1.FlatAppearance.BorderSize = 4;
            this.btnYear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear1.Location = new System.Drawing.Point(30, 20);
            this.btnYear1.Name = "btnYear1";
            this.btnYear1.Size = new System.Drawing.Size(120, 60);
            this.btnYear1.TabIndex = 16;
            this.btnYear1.Text = "Year1";
            this.btnYear1.UseVisualStyleBackColor = false;
            this.btnYear1.Visible = false;
            this.btnYear1.Click += new System.EventHandler(this.YearButtonClick);
            // 
            // lblNoData
            // 
            this.lblNoData.BackColor = System.Drawing.Color.Black;
            this.lblNoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Red;
            this.lblNoData.Location = new System.Drawing.Point(251, 344);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(320, 27);
            this.lblNoData.TabIndex = 9;
            this.lblNoData.Text = "No data to load";
            this.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFebruary
            // 
            this.btnFebruary.BackColor = System.Drawing.Color.DarkGray;
            this.btnFebruary.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFebruary.FlatAppearance.BorderSize = 4;
            this.btnFebruary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFebruary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFebruary.Location = new System.Drawing.Point(230, 141);
            this.btnFebruary.Name = "btnFebruary";
            this.btnFebruary.Size = new System.Drawing.Size(160, 50);
            this.btnFebruary.TabIndex = 15;
            this.btnFebruary.Text = "February";
            this.btnFebruary.UseVisualStyleBackColor = false;
            this.btnFebruary.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnMarch
            // 
            this.btnMarch.BackColor = System.Drawing.Color.DarkGray;
            this.btnMarch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMarch.FlatAppearance.BorderSize = 4;
            this.btnMarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarch.Location = new System.Drawing.Point(430, 141);
            this.btnMarch.Name = "btnMarch";
            this.btnMarch.Size = new System.Drawing.Size(160, 50);
            this.btnMarch.TabIndex = 14;
            this.btnMarch.Text = "March";
            this.btnMarch.UseVisualStyleBackColor = false;
            this.btnMarch.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnApril
            // 
            this.btnApril.BackColor = System.Drawing.Color.DarkGray;
            this.btnApril.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnApril.FlatAppearance.BorderSize = 4;
            this.btnApril.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApril.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApril.Location = new System.Drawing.Point(630, 141);
            this.btnApril.Name = "btnApril";
            this.btnApril.Size = new System.Drawing.Size(160, 50);
            this.btnApril.TabIndex = 13;
            this.btnApril.Text = "April";
            this.btnApril.UseVisualStyleBackColor = false;
            this.btnApril.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnSeptember
            // 
            this.btnSeptember.BackColor = System.Drawing.Color.DarkGray;
            this.btnSeptember.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSeptember.FlatAppearance.BorderSize = 4;
            this.btnSeptember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeptember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeptember.Location = new System.Drawing.Point(30, 281);
            this.btnSeptember.Name = "btnSeptember";
            this.btnSeptember.Size = new System.Drawing.Size(160, 50);
            this.btnSeptember.TabIndex = 12;
            this.btnSeptember.Text = "September";
            this.btnSeptember.UseVisualStyleBackColor = false;
            this.btnSeptember.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnMay
            // 
            this.btnMay.BackColor = System.Drawing.Color.DarkGray;
            this.btnMay.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMay.FlatAppearance.BorderSize = 4;
            this.btnMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMay.Location = new System.Drawing.Point(31, 211);
            this.btnMay.Name = "btnMay";
            this.btnMay.Size = new System.Drawing.Size(160, 50);
            this.btnMay.TabIndex = 11;
            this.btnMay.Text = "May";
            this.btnMay.UseVisualStyleBackColor = false;
            this.btnMay.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnNovember
            // 
            this.btnNovember.BackColor = System.Drawing.Color.DarkGray;
            this.btnNovember.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNovember.FlatAppearance.BorderSize = 4;
            this.btnNovember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovember.Location = new System.Drawing.Point(430, 281);
            this.btnNovember.Name = "btnNovember";
            this.btnNovember.Size = new System.Drawing.Size(160, 50);
            this.btnNovember.TabIndex = 10;
            this.btnNovember.Text = "November";
            this.btnNovember.UseVisualStyleBackColor = false;
            this.btnNovember.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnDecember
            // 
            this.btnDecember.BackColor = System.Drawing.Color.DarkGray;
            this.btnDecember.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDecember.FlatAppearance.BorderSize = 4;
            this.btnDecember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecember.Location = new System.Drawing.Point(630, 281);
            this.btnDecember.Name = "btnDecember";
            this.btnDecember.Size = new System.Drawing.Size(160, 50);
            this.btnDecember.TabIndex = 9;
            this.btnDecember.Text = "December";
            this.btnDecember.UseVisualStyleBackColor = false;
            this.btnDecember.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnOctober
            // 
            this.btnOctober.BackColor = System.Drawing.Color.DarkGray;
            this.btnOctober.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOctober.FlatAppearance.BorderSize = 4;
            this.btnOctober.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOctober.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOctober.Location = new System.Drawing.Point(230, 281);
            this.btnOctober.Name = "btnOctober";
            this.btnOctober.Size = new System.Drawing.Size(160, 50);
            this.btnOctober.TabIndex = 8;
            this.btnOctober.Text = "October";
            this.btnOctober.UseVisualStyleBackColor = false;
            this.btnOctober.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnJune
            // 
            this.btnJune.BackColor = System.Drawing.Color.DarkGray;
            this.btnJune.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnJune.FlatAppearance.BorderSize = 4;
            this.btnJune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJune.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJune.Location = new System.Drawing.Point(230, 211);
            this.btnJune.Name = "btnJune";
            this.btnJune.Size = new System.Drawing.Size(160, 50);
            this.btnJune.TabIndex = 7;
            this.btnJune.Text = "June";
            this.btnJune.UseVisualStyleBackColor = false;
            this.btnJune.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnJuly
            // 
            this.btnJuly.BackColor = System.Drawing.Color.DarkGray;
            this.btnJuly.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnJuly.FlatAppearance.BorderSize = 4;
            this.btnJuly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuly.Location = new System.Drawing.Point(430, 211);
            this.btnJuly.Name = "btnJuly";
            this.btnJuly.Size = new System.Drawing.Size(160, 50);
            this.btnJuly.TabIndex = 6;
            this.btnJuly.Text = "July";
            this.btnJuly.UseVisualStyleBackColor = false;
            this.btnJuly.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnAugust
            // 
            this.btnAugust.BackColor = System.Drawing.Color.DarkGray;
            this.btnAugust.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAugust.FlatAppearance.BorderSize = 4;
            this.btnAugust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAugust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAugust.Location = new System.Drawing.Point(630, 211);
            this.btnAugust.Name = "btnAugust";
            this.btnAugust.Size = new System.Drawing.Size(160, 50);
            this.btnAugust.TabIndex = 5;
            this.btnAugust.Text = "August";
            this.btnAugust.UseVisualStyleBackColor = false;
            this.btnAugust.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // btnJanuary
            // 
            this.btnJanuary.BackColor = System.Drawing.Color.DarkGray;
            this.btnJanuary.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnJanuary.FlatAppearance.BorderSize = 4;
            this.btnJanuary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJanuary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJanuary.Location = new System.Drawing.Point(30, 141);
            this.btnJanuary.Name = "btnJanuary";
            this.btnJanuary.Size = new System.Drawing.Size(160, 50);
            this.btnJanuary.TabIndex = 4;
            this.btnJanuary.Text = "January";
            this.btnJanuary.UseVisualStyleBackColor = false;
            this.btnJanuary.Click += new System.EventHandler(this.MonthButtonClick);
            // 
            // lblEditedEntries
            // 
            this.lblEditedEntries.AutoSize = true;
            this.lblEditedEntries.BackColor = System.Drawing.Color.DarkGray;
            this.lblEditedEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditedEntries.ForeColor = System.Drawing.Color.Gold;
            this.lblEditedEntries.Location = new System.Drawing.Point(805, 486);
            this.lblEditedEntries.Name = "lblEditedEntries";
            this.lblEditedEntries.Size = new System.Drawing.Size(16, 18);
            this.lblEditedEntries.TabIndex = 11;
            this.lblEditedEntries.Text = "0";
            this.lblEditedEntries.Visible = false;
            // 
            // lblDeletedEntries
            // 
            this.lblDeletedEntries.AutoSize = true;
            this.lblDeletedEntries.BackColor = System.Drawing.Color.DarkGray;
            this.lblDeletedEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletedEntries.ForeColor = System.Drawing.Color.Red;
            this.lblDeletedEntries.Location = new System.Drawing.Point(831, 486);
            this.lblDeletedEntries.Name = "lblDeletedEntries";
            this.lblDeletedEntries.Size = new System.Drawing.Size(16, 18);
            this.lblDeletedEntries.TabIndex = 12;
            this.lblDeletedEntries.Text = "0";
            this.lblDeletedEntries.Visible = false;
            // 
            // lblSavedEntries
            // 
            this.lblSavedEntries.AutoSize = true;
            this.lblSavedEntries.BackColor = System.Drawing.Color.DarkGray;
            this.lblSavedEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavedEntries.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSavedEntries.Location = new System.Drawing.Point(779, 486);
            this.lblSavedEntries.Name = "lblSavedEntries";
            this.lblSavedEntries.Size = new System.Drawing.Size(16, 18);
            this.lblSavedEntries.TabIndex = 13;
            this.lblSavedEntries.Text = "0";
            this.lblSavedEntries.Visible = false;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaveToFile.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSaveToFile.FlatAppearance.BorderSize = 4;
            this.btnSaveToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(672, 476);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(190, 43);
            this.btnSaveToFile.TabIndex = 9;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnNewEntrytoStats
            // 
            this.btnNewEntrytoStats.BackColor = System.Drawing.Color.DarkGray;
            this.btnNewEntrytoStats.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewEntrytoStats.FlatAppearance.BorderSize = 4;
            this.btnNewEntrytoStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEntrytoStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEntrytoStats.Location = new System.Drawing.Point(12, 476);
            this.btnNewEntrytoStats.Name = "btnNewEntrytoStats";
            this.btnNewEntrytoStats.Size = new System.Drawing.Size(190, 43);
            this.btnNewEntrytoStats.TabIndex = 14;
            this.btnNewEntrytoStats.Text = "Stats";
            this.btnNewEntrytoStats.UseVisualStyleBackColor = false;
            this.btnNewEntrytoStats.Click += new System.EventHandler(this.btnNewEntrytoStats_Click);
            // 
            // lblStatsFor
            // 
            this.lblStatsFor.BackColor = System.Drawing.Color.DarkGray;
            this.lblStatsFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsFor.Location = new System.Drawing.Point(12, 519);
            this.lblStatsFor.Name = "lblStatsFor";
            this.lblStatsFor.Size = new System.Drawing.Size(850, 36);
            this.lblStatsFor.TabIndex = 0;
            this.lblStatsFor.Text = "  Stats ";
            this.lblStatsFor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatsFor.Visible = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.Silver;
            this.pnlStats.Controls.Add(this.lblOverallBestDayDisplay);
            this.pnlStats.Controls.Add(this.btnSearchbyActivity);
            this.pnlStats.Controls.Add(this.lblTotalActivitiesDisplay);
            this.pnlStats.Controls.Add(this.lblHoursWorkedDisplay);
            this.pnlStats.Controls.Add(this.lblAverageHoursDisplay);
            this.pnlStats.Controls.Add(this.lblDaysWorkedDisplay);
            this.pnlStats.Controls.Add(this.lblMonthsWorkedDisplay);
            this.pnlStats.Controls.Add(this.txtbxProjectSearch);
            this.pnlStats.Controls.Add(this.lblTotalActivities);
            this.pnlStats.Controls.Add(this.lblMonthsWorked);
            this.pnlStats.Controls.Add(this.lblBestDayOverall);
            this.pnlStats.Controls.Add(this.lblDaysWorked);
            this.pnlStats.Controls.Add(this.lblTotalHoursWorked);
            this.pnlStats.Controls.Add(this.lblAverageHours);
            this.pnlStats.Location = new System.Drawing.Point(12, 553);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(850, 176);
            this.pnlStats.TabIndex = 16;
            // 
            // lblOverallBestDayDisplay
            // 
            this.lblOverallBestDayDisplay.AutoSize = true;
            this.lblOverallBestDayDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblOverallBestDayDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallBestDayDisplay.Location = new System.Drawing.Point(765, 68);
            this.lblOverallBestDayDisplay.Name = "lblOverallBestDayDisplay";
            this.lblOverallBestDayDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblOverallBestDayDisplay.TabIndex = 24;
            this.lblOverallBestDayDisplay.Text = "_";
            // 
            // btnSearchbyActivity
            // 
            this.btnSearchbyActivity.BackColor = System.Drawing.Color.DarkGray;
            this.btnSearchbyActivity.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSearchbyActivity.FlatAppearance.BorderSize = 3;
            this.btnSearchbyActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchbyActivity.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchbyActivity.Location = new System.Drawing.Point(21, 16);
            this.btnSearchbyActivity.Name = "btnSearchbyActivity";
            this.btnSearchbyActivity.Size = new System.Drawing.Size(158, 33);
            this.btnSearchbyActivity.TabIndex = 20;
            this.btnSearchbyActivity.Text = "Search by activity:";
            this.btnSearchbyActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchbyActivity.UseVisualStyleBackColor = false;
            this.btnSearchbyActivity.Click += new System.EventHandler(this.btnSearchforProject_Click);
            // 
            // lblTotalActivitiesDisplay
            // 
            this.lblTotalActivitiesDisplay.AutoSize = true;
            this.lblTotalActivitiesDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalActivitiesDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActivitiesDisplay.Location = new System.Drawing.Point(765, 7);
            this.lblTotalActivitiesDisplay.Name = "lblTotalActivitiesDisplay";
            this.lblTotalActivitiesDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblTotalActivitiesDisplay.TabIndex = 17;
            this.lblTotalActivitiesDisplay.Text = "_";
            // 
            // lblHoursWorkedDisplay
            // 
            this.lblHoursWorkedDisplay.AutoSize = true;
            this.lblHoursWorkedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblHoursWorkedDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorkedDisplay.Location = new System.Drawing.Point(484, 68);
            this.lblHoursWorkedDisplay.Name = "lblHoursWorkedDisplay";
            this.lblHoursWorkedDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblHoursWorkedDisplay.TabIndex = 15;
            this.lblHoursWorkedDisplay.Text = "_";
            // 
            // lblAverageHoursDisplay
            // 
            this.lblAverageHoursDisplay.AutoSize = true;
            this.lblAverageHoursDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageHoursDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageHoursDisplay.Location = new System.Drawing.Point(765, 39);
            this.lblAverageHoursDisplay.Name = "lblAverageHoursDisplay";
            this.lblAverageHoursDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblAverageHoursDisplay.TabIndex = 14;
            this.lblAverageHoursDisplay.Text = "_";
            // 
            // lblDaysWorkedDisplay
            // 
            this.lblDaysWorkedDisplay.AutoSize = true;
            this.lblDaysWorkedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysWorkedDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysWorkedDisplay.Location = new System.Drawing.Point(484, 39);
            this.lblDaysWorkedDisplay.Name = "lblDaysWorkedDisplay";
            this.lblDaysWorkedDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblDaysWorkedDisplay.TabIndex = 13;
            this.lblDaysWorkedDisplay.Text = "_";
            // 
            // lblMonthsWorkedDisplay
            // 
            this.lblMonthsWorkedDisplay.AutoSize = true;
            this.lblMonthsWorkedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthsWorkedDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsWorkedDisplay.Location = new System.Drawing.Point(484, 8);
            this.lblMonthsWorkedDisplay.Name = "lblMonthsWorkedDisplay";
            this.lblMonthsWorkedDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblMonthsWorkedDisplay.TabIndex = 12;
            this.lblMonthsWorkedDisplay.Text = "_";
            // 
            // txtbxProjectSearch
            // 
            this.txtbxProjectSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProjectSearch.Location = new System.Drawing.Point(21, 55);
            this.txtbxProjectSearch.Name = "txtbxProjectSearch";
            this.txtbxProjectSearch.Size = new System.Drawing.Size(229, 22);
            this.txtbxProjectSearch.TabIndex = 10;
            this.txtbxProjectSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxProjectSearch_KeyDown);
            // 
            // lblTotalActivities
            // 
            this.lblTotalActivities.AutoSize = true;
            this.lblTotalActivities.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalActivities.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActivities.Location = new System.Drawing.Point(556, 10);
            this.lblTotalActivities.Name = "lblTotalActivities";
            this.lblTotalActivities.Size = new System.Drawing.Size(122, 24);
            this.lblTotalActivities.TabIndex = 9;
            this.lblTotalActivities.Text = "Total Activities:";
            // 
            // lblMonthsWorked
            // 
            this.lblMonthsWorked.AutoSize = true;
            this.lblMonthsWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthsWorked.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsWorked.Location = new System.Drawing.Point(304, 10);
            this.lblMonthsWorked.Name = "lblMonthsWorked";
            this.lblMonthsWorked.Size = new System.Drawing.Size(126, 24);
            this.lblMonthsWorked.TabIndex = 8;
            this.lblMonthsWorked.Text = "Months Worked:";
            // 
            // lblBestDayOverall
            // 
            this.lblBestDayOverall.AutoSize = true;
            this.lblBestDayOverall.BackColor = System.Drawing.Color.Transparent;
            this.lblBestDayOverall.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestDayOverall.Location = new System.Drawing.Point(556, 68);
            this.lblBestDayOverall.Name = "lblBestDayOverall";
            this.lblBestDayOverall.Size = new System.Drawing.Size(146, 24);
            this.lblBestDayOverall.TabIndex = 7;
            this.lblBestDayOverall.Text = "Best Day - Overall: ";
            // 
            // lblDaysWorked
            // 
            this.lblDaysWorked.AutoSize = true;
            this.lblDaysWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysWorked.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysWorked.Location = new System.Drawing.Point(304, 39);
            this.lblDaysWorked.Name = "lblDaysWorked";
            this.lblDaysWorked.Size = new System.Drawing.Size(147, 24);
            this.lblDaysWorked.TabIndex = 5;
            this.lblDaysWorked.Text = "Total Days Worked:";
            // 
            // lblTotalHoursWorked
            // 
            this.lblTotalHoursWorked.AutoSize = true;
            this.lblTotalHoursWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalHoursWorked.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoursWorked.Location = new System.Drawing.Point(304, 68);
            this.lblTotalHoursWorked.Name = "lblTotalHoursWorked";
            this.lblTotalHoursWorked.Size = new System.Drawing.Size(160, 24);
            this.lblTotalHoursWorked.TabIndex = 2;
            this.lblTotalHoursWorked.Text = "Total Hours Worked: ";
            // 
            // lblAverageHours
            // 
            this.lblAverageHours.AutoSize = true;
            this.lblAverageHours.BackColor = System.Drawing.Color.Transparent;
            this.lblAverageHours.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageHours.Location = new System.Drawing.Point(556, 39);
            this.lblAverageHours.Name = "lblAverageHours";
            this.lblAverageHours.Size = new System.Drawing.Size(182, 24);
            this.lblAverageHours.TabIndex = 1;
            this.lblAverageHours.Text = "Average Hours per Day: ";
            // 
            // lblSelectionDaysWorkedDisplay
            // 
            this.lblSelectionDaysWorkedDisplay.AutoSize = true;
            this.lblSelectionDaysWorkedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionDaysWorkedDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionDaysWorkedDisplay.Location = new System.Drawing.Point(484, 20);
            this.lblSelectionDaysWorkedDisplay.Name = "lblSelectionDaysWorkedDisplay";
            this.lblSelectionDaysWorkedDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblSelectionDaysWorkedDisplay.TabIndex = 26;
            this.lblSelectionDaysWorkedDisplay.Text = "_";
            // 
            // lblSelectionDaysWorked
            // 
            this.lblSelectionDaysWorked.AutoSize = true;
            this.lblSelectionDaysWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionDaysWorked.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionDaysWorked.Location = new System.Drawing.Point(304, 20);
            this.lblSelectionDaysWorked.Name = "lblSelectionDaysWorked";
            this.lblSelectionDaysWorked.Size = new System.Drawing.Size(107, 24);
            this.lblSelectionDaysWorked.TabIndex = 25;
            this.lblSelectionDaysWorked.Text = "Days Worked:";
            // 
            // lblSelectionBestDay
            // 
            this.lblSelectionBestDay.AutoSize = true;
            this.lblSelectionBestDay.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionBestDay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionBestDay.Location = new System.Drawing.Point(556, 20);
            this.lblSelectionBestDay.Name = "lblSelectionBestDay";
            this.lblSelectionBestDay.Size = new System.Drawing.Size(77, 24);
            this.lblSelectionBestDay.TabIndex = 23;
            this.lblSelectionBestDay.Text = "Best Day:";
            // 
            // lblStatsForActivity
            // 
            this.lblStatsForActivity.AutoSize = true;
            this.lblStatsForActivity.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatsForActivity.Location = new System.Drawing.Point(20, 0);
            this.lblStatsForActivity.Name = "lblStatsForActivity";
            this.lblStatsForActivity.Size = new System.Drawing.Size(61, 22);
            this.lblStatsForActivity.TabIndex = 22;
            this.lblStatsForActivity.Text = "Select:";
            // 
            // cmbxMostActive
            // 
            this.cmbxMostActive.BackColor = System.Drawing.Color.White;
            this.cmbxMostActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMostActive.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMostActive.FormattingEnabled = true;
            this.cmbxMostActive.Location = new System.Drawing.Point(21, 30);
            this.cmbxMostActive.MaxDropDownItems = 3;
            this.cmbxMostActive.Name = "cmbxMostActive";
            this.cmbxMostActive.Size = new System.Drawing.Size(229, 26);
            this.cmbxMostActive.TabIndex = 21;
            this.cmbxMostActive.SelectedIndexChanged += new System.EventHandler(this.cmbxMostActive_SelectedIndexChanged);
            // 
            // lblSelectionHoursWorkedDisplay
            // 
            this.lblSelectionHoursWorkedDisplay.AutoSize = true;
            this.lblSelectionHoursWorkedDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionHoursWorkedDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionHoursWorkedDisplay.Location = new System.Drawing.Point(484, 47);
            this.lblSelectionHoursWorkedDisplay.Name = "lblSelectionHoursWorkedDisplay";
            this.lblSelectionHoursWorkedDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblSelectionHoursWorkedDisplay.TabIndex = 19;
            this.lblSelectionHoursWorkedDisplay.Text = "_";
            // 
            // lblSelectionBestDayDisplay
            // 
            this.lblSelectionBestDayDisplay.AutoSize = true;
            this.lblSelectionBestDayDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionBestDayDisplay.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionBestDayDisplay.Location = new System.Drawing.Point(765, 20);
            this.lblSelectionBestDayDisplay.Name = "lblSelectionBestDayDisplay";
            this.lblSelectionBestDayDisplay.Size = new System.Drawing.Size(18, 24);
            this.lblSelectionBestDayDisplay.TabIndex = 16;
            this.lblSelectionBestDayDisplay.Text = "_";
            // 
            // lblSelectionHoursWorked
            // 
            this.lblSelectionHoursWorked.AutoSize = true;
            this.lblSelectionHoursWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectionHoursWorked.Font = new System.Drawing.Font("Sitka Banner", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectionHoursWorked.Location = new System.Drawing.Point(304, 47);
            this.lblSelectionHoursWorked.Name = "lblSelectionHoursWorked";
            this.lblSelectionHoursWorked.Size = new System.Drawing.Size(116, 24);
            this.lblSelectionHoursWorked.TabIndex = 3;
            this.lblSelectionHoursWorked.Text = "Hours Worked:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(874, 24);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewSaveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewSaveFileToolStripMenuItem
            // 
            this.createNewSaveFileToolStripMenuItem.Name = "createNewSaveFileToolStripMenuItem";
            this.createNewSaveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewSaveFileToolStripMenuItem.Text = "New save file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem.Text = "Help";
            // 
            // pnlSelectSearch
            // 
            this.pnlSelectSearch.BackColor = System.Drawing.Color.LightGray;
            this.pnlSelectSearch.Controls.Add(this.lblSelectionDaysWorkedDisplay);
            this.pnlSelectSearch.Controls.Add(this.cmbxMostActive);
            this.pnlSelectSearch.Controls.Add(this.lblSelectionDaysWorked);
            this.pnlSelectSearch.Controls.Add(this.lblSelectionHoursWorked);
            this.pnlSelectSearch.Controls.Add(this.lblSelectionBestDayDisplay);
            this.pnlSelectSearch.Controls.Add(this.lblSelectionBestDay);
            this.pnlSelectSearch.Controls.Add(this.lblSelectionHoursWorkedDisplay);
            this.pnlSelectSearch.Controls.Add(this.lblStatsForActivity);
            this.pnlSelectSearch.Location = new System.Drawing.Point(12, 651);
            this.pnlSelectSearch.Name = "pnlSelectSearch";
            this.pnlSelectSearch.Size = new System.Drawing.Size(850, 79);
            this.pnlSelectSearch.TabIndex = 27;
            this.pnlSelectSearch.Visible = false;
            // 
            // TimeLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(874, 741);
            this.Controls.Add(this.lblStatsFor);
            this.Controls.Add(this.btnNewEntrytoStats);
            this.Controls.Add(this.lblDeletedEntries);
            this.Controls.Add(this.btnCalendartoGrid);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lblSavedEntries);
            this.Controls.Add(this.pnlMonths);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblEditedEntries);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.pnlNewEntry);
            this.Controls.Add(this.pnlSelectSearch);
            this.Controls.Add(this.pnlStats);
            this.Name = "TimeLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeLogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeLogger_FormClosing);
            this.Load += new System.EventHandler(this.TimeLogger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlNewEntry.ResumeLayout(false);
            this.pnlNewEntry.PerformLayout();
            this.pnlMonths.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlSelectSearch.ResumeLayout(false);
            this.pnlSelectSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCalendartoGrid;
        private System.Windows.Forms.Panel pnlNewEntry;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.TextBox txtbxDate;
        private System.Windows.Forms.Panel pnlMonths;
        private System.Windows.Forms.Button btnFebruary;
        private System.Windows.Forms.Button btnMarch;
        private System.Windows.Forms.Button btnApril;
        private System.Windows.Forms.Button btnSeptember;
        private System.Windows.Forms.Button btnMay;
        private System.Windows.Forms.Button btnNovember;
        private System.Windows.Forms.Button btnDecember;
        private System.Windows.Forms.Button btnOctober;
        private System.Windows.Forms.Button btnJune;
        private System.Windows.Forms.Button btnJuly;
        private System.Windows.Forms.Button btnAugust;
        private System.Windows.Forms.Button btnJanuary;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbxComments;
        private System.Windows.Forms.TextBox txtbxAchievements;
        private System.Windows.Forms.TextBox txtbxHours;
        private System.Windows.Forms.TextBox txtbxActivity;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Button btnEditEntry;
        private System.Windows.Forms.Label lblEditedEntries;
        private System.Windows.Forms.Label lblDeletedEntries;
        private System.Windows.Forms.Label lblSavedEntries;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnNewEntrytoStats;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Label lblStatsFor;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblBestDayOverall;
        private System.Windows.Forms.Label lblDaysWorked;
        private System.Windows.Forms.Label lblSelectionHoursWorked;
        private System.Windows.Forms.Label lblTotalHoursWorked;
        private System.Windows.Forms.Label lblAverageHours;
        private System.Windows.Forms.TextBox txtbxProjectSearch;
        private System.Windows.Forms.Label lblTotalActivities;
        private System.Windows.Forms.Label lblMonthsWorked;
        private System.Windows.Forms.Label lblSelectionHoursWorkedDisplay;
        private System.Windows.Forms.Label lblTotalActivitiesDisplay;
        private System.Windows.Forms.Label lblSelectionBestDayDisplay;
        private System.Windows.Forms.Label lblHoursWorkedDisplay;
        private System.Windows.Forms.Label lblAverageHoursDisplay;
        private System.Windows.Forms.Label lblDaysWorkedDisplay;
        private System.Windows.Forms.Label lblMonthsWorkedDisplay;
        private System.Windows.Forms.Button btnSearchbyActivity;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewSaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Button btnYear4;
        private System.Windows.Forms.Button btnYear5;
        private System.Windows.Forms.Button btnYear2;
        private System.Windows.Forms.Button btnYear3;
        private System.Windows.Forms.Button btnYear1;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAchievements;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComments;
        private System.Windows.Forms.ComboBox cmbxMostActive;
        private System.Windows.Forms.Label lblStatsForActivity;
        private System.Windows.Forms.Label lblSelectionBestDay;
        private System.Windows.Forms.Label lblOverallBestDayDisplay;
        private System.Windows.Forms.Label lblSelectionDaysWorkedDisplay;
        private System.Windows.Forms.Label lblSelectionDaysWorked;
        private System.Windows.Forms.Panel pnlSelectSearch;
    }
}

