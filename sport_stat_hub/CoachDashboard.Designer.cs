namespace sport_stat_hub
{
    partial class CoachDashboard
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabTraining = new System.Windows.Forms.TabPage();
            this.tabMatchStats = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.dgvMyTeam = new System.Windows.Forms.DataGridView();
            this.dtpTrainingDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFocusArea = new System.Windows.Forms.ComboBox();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.cmbSelectMatch = new System.Windows.Forms.ComboBox();
            this.cmbSelectAthlete = new System.Windows.Forms.ComboBox();
            this.numGoals = new System.Windows.Forms.NumericUpDown();
            this.numAssists = new System.Windows.Forms.NumericUpDown();
            this.btnSaveStats = new System.Windows.Forms.Button();
            this.dgvReportResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.txtLicenseLevel = new System.Windows.Forms.TextBox();
            this.txtTactics = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numYellowCards = new System.Windows.Forms.NumericUpDown();
            this.numRedCards = new System.Windows.Forms.NumericUpDown();
            this.numMinutesPlayed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbReportSelector = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblWinRateValue = new System.Windows.Forms.Label();
            this.lblTotalGoalsValue = new System.Windows.Forms.Label();
            this.lblTotalWinsValue = new System.Windows.Forms.Label();
            this.lblCleanSheetsValue = new System.Windows.Forms.Label();
            this.lblTotalPointsValue = new System.Windows.Forms.Label();
            this.lblInjuryCountValue = new System.Windows.Forms.Label();
            this.lblGoalsPerGameValue = new System.Windows.Forms.Label();
            this.lblTotalAssistsValue = new System.Windows.Forms.Label();
            this.btnLogoutProfile = new System.Windows.Forms.Button();
            this.btnLogoutTeam = new System.Windows.Forms.Button();
            this.btnLogoutTraining = new System.Windows.Forms.Button();
            this.btnLogoutStats = new System.Windows.Forms.Button();
            this.btnLogoutReport = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabTeam.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabTraining.SuspendLayout();
            this.tabMatchStats.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYellowCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesPlayed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabProfile);
            this.tab1.Controls.Add(this.tabTeam);
            this.tab1.Controls.Add(this.tabTraining);
            this.tab1.Controls.Add(this.tabMatchStats);
            this.tab1.Controls.Add(this.tabReports);
            this.tab1.Location = new System.Drawing.Point(-5, -1);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(807, 450);
            this.tab1.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.btnLogoutProfile);
            this.tabProfile.Controls.Add(this.groupBox1);
            this.tabProfile.Controls.Add(this.txtTactics);
            this.tabProfile.Controls.Add(this.txtLicenseLevel);
            this.tabProfile.Controls.Add(this.txtCoachName);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.label3);
            this.tabProfile.Controls.Add(this.label2);
            this.tabProfile.Controls.Add(this.label1);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfile.Size = new System.Drawing.Size(799, 424);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tabTeam
            // 
            this.tabTeam.Controls.Add(this.btnLogoutTeam);
            this.tabTeam.Controls.Add(this.dgvMyTeam);
            this.tabTeam.Location = new System.Drawing.Point(4, 22);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeam.Size = new System.Drawing.Size(799, 424);
            this.tabTeam.TabIndex = 1;
            this.tabTeam.Text = "Team";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(801, 448);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(8, 8);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabTraining
            // 
            this.tabTraining.Controls.Add(this.btnLogoutTraining);
            this.tabTraining.Controls.Add(this.label10);
            this.tabTraining.Controls.Add(this.label9);
            this.tabTraining.Controls.Add(this.label8);
            this.tabTraining.Controls.Add(this.btnAddTraining);
            this.tabTraining.Controls.Add(this.numDuration);
            this.tabTraining.Controls.Add(this.cmbFocusArea);
            this.tabTraining.Controls.Add(this.dtpTrainingDate);
            this.tabTraining.Location = new System.Drawing.Point(4, 22);
            this.tabTraining.Name = "tabTraining";
            this.tabTraining.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraining.Size = new System.Drawing.Size(799, 424);
            this.tabTraining.TabIndex = 2;
            this.tabTraining.Text = "Training";
            this.tabTraining.UseVisualStyleBackColor = true;
            // 
            // tabMatchStats
            // 
            this.tabMatchStats.Controls.Add(this.btnLogoutStats);
            this.tabMatchStats.Controls.Add(this.numMinutesPlayed);
            this.tabMatchStats.Controls.Add(this.numRedCards);
            this.tabMatchStats.Controls.Add(this.numYellowCards);
            this.tabMatchStats.Controls.Add(this.label15);
            this.tabMatchStats.Controls.Add(this.label14);
            this.tabMatchStats.Controls.Add(this.label13);
            this.tabMatchStats.Controls.Add(this.label7);
            this.tabMatchStats.Controls.Add(this.label6);
            this.tabMatchStats.Controls.Add(this.label5);
            this.tabMatchStats.Controls.Add(this.label4);
            this.tabMatchStats.Controls.Add(this.btnSaveStats);
            this.tabMatchStats.Controls.Add(this.numAssists);
            this.tabMatchStats.Controls.Add(this.numGoals);
            this.tabMatchStats.Controls.Add(this.cmbSelectAthlete);
            this.tabMatchStats.Controls.Add(this.cmbSelectMatch);
            this.tabMatchStats.Location = new System.Drawing.Point(4, 22);
            this.tabMatchStats.Name = "tabMatchStats";
            this.tabMatchStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatchStats.Size = new System.Drawing.Size(799, 424);
            this.tabMatchStats.TabIndex = 3;
            this.tabMatchStats.Text = "Match Stats";
            this.tabMatchStats.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.btnLogoutReport);
            this.tabReports.Controls.Add(this.groupBox3);
            this.tabReports.Controls.Add(this.groupBox2);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(799, 424);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Leve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preferred Tactics:";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(183, 209);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "Update My Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // dgvMyTeam
            // 
            this.dgvMyTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyTeam.Location = new System.Drawing.Point(101, 91);
            this.dgvMyTeam.Name = "dgvMyTeam";
            this.dgvMyTeam.Size = new System.Drawing.Size(240, 150);
            this.dgvMyTeam.TabIndex = 0;
            // 
            // dtpTrainingDate
            // 
            this.dtpTrainingDate.Location = new System.Drawing.Point(181, 57);
            this.dtpTrainingDate.Name = "dtpTrainingDate";
            this.dtpTrainingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTrainingDate.TabIndex = 0;
            // 
            // cmbFocusArea
            // 
            this.cmbFocusArea.FormattingEnabled = true;
            this.cmbFocusArea.Location = new System.Drawing.Point(32, 57);
            this.cmbFocusArea.Name = "cmbFocusArea";
            this.cmbFocusArea.Size = new System.Drawing.Size(121, 21);
            this.cmbFocusArea.TabIndex = 1;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(33, 116);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 20);
            this.numDuration.TabIndex = 2;
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(197, 199);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(115, 23);
            this.btnAddTraining.TabIndex = 3;
            this.btnAddTraining.Text = "Add Training Session";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            // 
            // cmbSelectMatch
            // 
            this.cmbSelectMatch.FormattingEnabled = true;
            this.cmbSelectMatch.Location = new System.Drawing.Point(30, 45);
            this.cmbSelectMatch.Name = "cmbSelectMatch";
            this.cmbSelectMatch.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectMatch.TabIndex = 0;
            // 
            // cmbSelectAthlete
            // 
            this.cmbSelectAthlete.FormattingEnabled = true;
            this.cmbSelectAthlete.Location = new System.Drawing.Point(275, 45);
            this.cmbSelectAthlete.Name = "cmbSelectAthlete";
            this.cmbSelectAthlete.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectAthlete.TabIndex = 1;
            // 
            // numGoals
            // 
            this.numGoals.Location = new System.Drawing.Point(276, 101);
            this.numGoals.Name = "numGoals";
            this.numGoals.Size = new System.Drawing.Size(120, 20);
            this.numGoals.TabIndex = 2;
            // 
            // numAssists
            // 
            this.numAssists.Location = new System.Drawing.Point(276, 159);
            this.numAssists.Name = "numAssists";
            this.numAssists.Size = new System.Drawing.Size(120, 20);
            this.numAssists.TabIndex = 3;
            // 
            // btnSaveStats
            // 
            this.btnSaveStats.Location = new System.Drawing.Point(81, 321);
            this.btnSaveStats.Name = "btnSaveStats";
            this.btnSaveStats.Size = new System.Drawing.Size(126, 23);
            this.btnSaveStats.TabIndex = 4;
            this.btnSaveStats.Text = "Save Performance";
            this.btnSaveStats.UseVisualStyleBackColor = true;
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResults.Location = new System.Drawing.Point(48, 90);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.Size = new System.Drawing.Size(240, 150);
            this.dgvReportResults.TabIndex = 3;
            this.dgvReportResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportResults_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Match:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Select Athlete:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Goals Scored:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Assists:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Focus Area:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Scheduled Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Duration (Minutes):";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(159, 49);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.ReadOnly = true;
            this.txtCoachName.Size = new System.Drawing.Size(100, 20);
            this.txtCoachName.TabIndex = 4;
            // 
            // txtLicenseLevel
            // 
            this.txtLicenseLevel.Location = new System.Drawing.Point(159, 81);
            this.txtLicenseLevel.Name = "txtLicenseLevel";
            this.txtLicenseLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseLevel.TabIndex = 5;
            // 
            // txtTactics
            // 
            this.txtTactics.Location = new System.Drawing.Point(159, 117);
            this.txtTactics.Name = "txtTactics";
            this.txtTactics.Size = new System.Drawing.Size(100, 20);
            this.txtTactics.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.btnUpdatePassword);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(426, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Security";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "New Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Confirm Password";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Location = new System.Drawing.Point(65, 96);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePassword.TabIndex = 2;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(99, 24);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(99, 55);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Yellow Cards:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Red Cards:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Minutes Played:";
            // 
            // numYellowCards
            // 
            this.numYellowCards.Location = new System.Drawing.Point(108, 107);
            this.numYellowCards.Name = "numYellowCards";
            this.numYellowCards.Size = new System.Drawing.Size(43, 20);
            this.numYellowCards.TabIndex = 12;
            // 
            // numRedCards
            // 
            this.numRedCards.Location = new System.Drawing.Point(108, 158);
            this.numRedCards.Name = "numRedCards";
            this.numRedCards.Size = new System.Drawing.Size(43, 20);
            this.numRedCards.TabIndex = 13;
            // 
            // numMinutesPlayed
            // 
            this.numMinutesPlayed.Location = new System.Drawing.Point(275, 220);
            this.numMinutesPlayed.Name = "numMinutesPlayed";
            this.numMinutesPlayed.Size = new System.Drawing.Size(120, 20);
            this.numMinutesPlayed.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalAssistsValue);
            this.groupBox2.Controls.Add(this.lblGoalsPerGameValue);
            this.groupBox2.Controls.Add(this.lblInjuryCountValue);
            this.groupBox2.Controls.Add(this.lblTotalPointsValue);
            this.groupBox2.Controls.Add(this.lblCleanSheetsValue);
            this.groupBox2.Controls.Add(this.lblTotalWinsValue);
            this.groupBox2.Controls.Add(this.lblTotalGoalsValue);
            this.groupBox2.Controls.Add(this.lblWinRateValue);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(23, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 171);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Season Summary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Win Rate:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Total Goals:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Total Wins:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Clean Sheets:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(121, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Total Points:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(121, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Current Injuries:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(121, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Goals Per Game:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(121, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Total Assists:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerate);
            this.groupBox3.Controls.Add(this.cmbReportSelector);
            this.groupBox3.Controls.Add(this.dgvReportResults);
            this.groupBox3.Location = new System.Drawing.Point(314, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 292);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Team Detailed Reports";
            // 
            // cmbReportSelector
            // 
            this.cmbReportSelector.FormattingEnabled = true;
            this.cmbReportSelector.Items.AddRange(new object[] {
            "Squad Top Scores",
            "Full Injury List",
            "Training Attendance"});
            this.cmbReportSelector.Location = new System.Drawing.Point(18, 37);
            this.cmbReportSelector.Name = "cmbReportSelector";
            this.cmbReportSelector.Size = new System.Drawing.Size(121, 21);
            this.cmbReportSelector.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(48, 263);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // lblWinRateValue
            // 
            this.lblWinRateValue.AutoSize = true;
            this.lblWinRateValue.Location = new System.Drawing.Point(74, 21);
            this.lblWinRateValue.Name = "lblWinRateValue";
            this.lblWinRateValue.Size = new System.Drawing.Size(41, 13);
            this.lblWinRateValue.TabIndex = 8;
            this.lblWinRateValue.Text = "label24";
            // 
            // lblTotalGoalsValue
            // 
            this.lblTotalGoalsValue.AutoSize = true;
            this.lblTotalGoalsValue.Location = new System.Drawing.Point(74, 48);
            this.lblTotalGoalsValue.Name = "lblTotalGoalsValue";
            this.lblTotalGoalsValue.Size = new System.Drawing.Size(41, 13);
            this.lblTotalGoalsValue.TabIndex = 9;
            this.lblTotalGoalsValue.Text = "label25";
            // 
            // lblTotalWinsValue
            // 
            this.lblTotalWinsValue.AutoSize = true;
            this.lblTotalWinsValue.Location = new System.Drawing.Point(74, 80);
            this.lblTotalWinsValue.Name = "lblTotalWinsValue";
            this.lblTotalWinsValue.Size = new System.Drawing.Size(41, 13);
            this.lblTotalWinsValue.TabIndex = 10;
            this.lblTotalWinsValue.Text = "label26";
            // 
            // lblCleanSheetsValue
            // 
            this.lblCleanSheetsValue.AutoSize = true;
            this.lblCleanSheetsValue.Location = new System.Drawing.Point(74, 111);
            this.lblCleanSheetsValue.Name = "lblCleanSheetsValue";
            this.lblCleanSheetsValue.Size = new System.Drawing.Size(41, 13);
            this.lblCleanSheetsValue.TabIndex = 11;
            this.lblCleanSheetsValue.Text = "label27";
            // 
            // lblTotalPointsValue
            // 
            this.lblTotalPointsValue.AutoSize = true;
            this.lblTotalPointsValue.Location = new System.Drawing.Point(207, 21);
            this.lblTotalPointsValue.Name = "lblTotalPointsValue";
            this.lblTotalPointsValue.Size = new System.Drawing.Size(41, 13);
            this.lblTotalPointsValue.TabIndex = 12;
            this.lblTotalPointsValue.Text = "label28";
            // 
            // lblInjuryCountValue
            // 
            this.lblInjuryCountValue.AutoSize = true;
            this.lblInjuryCountValue.Location = new System.Drawing.Point(207, 48);
            this.lblInjuryCountValue.Name = "lblInjuryCountValue";
            this.lblInjuryCountValue.Size = new System.Drawing.Size(41, 13);
            this.lblInjuryCountValue.TabIndex = 13;
            this.lblInjuryCountValue.Text = "label29";
            // 
            // lblGoalsPerGameValue
            // 
            this.lblGoalsPerGameValue.AutoSize = true;
            this.lblGoalsPerGameValue.Location = new System.Drawing.Point(208, 80);
            this.lblGoalsPerGameValue.Name = "lblGoalsPerGameValue";
            this.lblGoalsPerGameValue.Size = new System.Drawing.Size(41, 13);
            this.lblGoalsPerGameValue.TabIndex = 14;
            this.lblGoalsPerGameValue.Text = "label30";
            // 
            // lblTotalAssistsValue
            // 
            this.lblTotalAssistsValue.AutoSize = true;
            this.lblTotalAssistsValue.Location = new System.Drawing.Point(208, 111);
            this.lblTotalAssistsValue.Name = "lblTotalAssistsValue";
            this.lblTotalAssistsValue.Size = new System.Drawing.Size(41, 13);
            this.lblTotalAssistsValue.TabIndex = 15;
            this.lblTotalAssistsValue.Text = "label31";
            // 
            // btnLogoutProfile
            // 
            this.btnLogoutProfile.Location = new System.Drawing.Point(714, 394);
            this.btnLogoutProfile.Name = "btnLogoutProfile";
            this.btnLogoutProfile.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutProfile.TabIndex = 8;
            this.btnLogoutProfile.Text = "Logout";
            this.btnLogoutProfile.UseVisualStyleBackColor = true;
            this.btnLogoutProfile.Click += new System.EventHandler(this.btnLogoutProfile_Click);
            // 
            // btnLogoutTeam
            // 
            this.btnLogoutTeam.Location = new System.Drawing.Point(714, 394);
            this.btnLogoutTeam.Name = "btnLogoutTeam";
            this.btnLogoutTeam.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutTeam.TabIndex = 1;
            this.btnLogoutTeam.Text = "Logout";
            this.btnLogoutTeam.UseVisualStyleBackColor = true;
            this.btnLogoutTeam.Click += new System.EventHandler(this.btnLogoutTeam_Click);
            // 
            // btnLogoutTraining
            // 
            this.btnLogoutTraining.Location = new System.Drawing.Point(714, 395);
            this.btnLogoutTraining.Name = "btnLogoutTraining";
            this.btnLogoutTraining.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutTraining.TabIndex = 7;
            this.btnLogoutTraining.Text = "Logout";
            this.btnLogoutTraining.UseVisualStyleBackColor = true;
            this.btnLogoutTraining.Click += new System.EventHandler(this.btnLogoutTraining_Click);
            // 
            // btnLogoutStats
            // 
            this.btnLogoutStats.Location = new System.Drawing.Point(714, 394);
            this.btnLogoutStats.Name = "btnLogoutStats";
            this.btnLogoutStats.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutStats.TabIndex = 15;
            this.btnLogoutStats.Text = "Logout";
            this.btnLogoutStats.UseVisualStyleBackColor = true;
            this.btnLogoutStats.Click += new System.EventHandler(this.btnLogoutStats_Click);
            // 
            // btnLogoutReport
            // 
            this.btnLogoutReport.Location = new System.Drawing.Point(714, 394);
            this.btnLogoutReport.Name = "btnLogoutReport";
            this.btnLogoutReport.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutReport.TabIndex = 6;
            this.btnLogoutReport.Text = "Logout";
            this.btnLogoutReport.UseVisualStyleBackColor = true;
            this.btnLogoutReport.Click += new System.EventHandler(this.btnLogoutReport_Click);
            // 
            // CoachDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tab1);
            this.Name = "CoachDashboard";
            this.Text = "Coach Dashboard";
            this.tab1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.tabTeam.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabTraining.ResumeLayout(false);
            this.tabTraining.PerformLayout();
            this.tabMatchStats.ResumeLayout(false);
            this.tabMatchStats.PerformLayout();
            this.tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAssists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYellowCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutesPlayed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.TabPage tabTraining;
        private System.Windows.Forms.TabPage tabMatchStats;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMyTeam;
        private System.Windows.Forms.ComboBox cmbFocusArea;
        private System.Windows.Forms.DateTimePicker dtpTrainingDate;
        private System.Windows.Forms.Button btnAddTraining;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Button btnSaveStats;
        private System.Windows.Forms.NumericUpDown numAssists;
        private System.Windows.Forms.NumericUpDown numGoals;
        private System.Windows.Forms.ComboBox cmbSelectAthlete;
        private System.Windows.Forms.ComboBox cmbSelectMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReportResults;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTactics;
        private System.Windows.Forms.TextBox txtLicenseLevel;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numMinutesPlayed;
        private System.Windows.Forms.NumericUpDown numRedCards;
        private System.Windows.Forms.NumericUpDown numYellowCards;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbReportSelector;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblGoalsPerGameValue;
        private System.Windows.Forms.Label lblInjuryCountValue;
        private System.Windows.Forms.Label lblTotalPointsValue;
        private System.Windows.Forms.Label lblCleanSheetsValue;
        private System.Windows.Forms.Label lblTotalWinsValue;
        private System.Windows.Forms.Label lblTotalGoalsValue;
        private System.Windows.Forms.Label lblWinRateValue;
        private System.Windows.Forms.Label lblTotalAssistsValue;
        private System.Windows.Forms.Button btnLogoutProfile;
        private System.Windows.Forms.Button btnLogoutTeam;
        private System.Windows.Forms.Button btnLogoutTraining;
        private System.Windows.Forms.Button btnLogoutStats;
        private System.Windows.Forms.Button btnLogoutReport;
    }
}