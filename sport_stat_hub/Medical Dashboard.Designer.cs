namespace sport_stat_hub
{
    partial class Medical_Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOutProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMedicalUpdatePass = new System.Windows.Forms.Button();
            this.txtMedicalConfirmPass = new System.Windows.Forms.TextBox();
            this.txtMedicalNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedicalCertID = new System.Windows.Forms.TextBox();
            this.txtMedicalSpecialty = new System.Windows.Forms.TextBox();
            this.txtMedicalName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLogOutRecord = new System.Windows.Forms.Button();
            this.btnSaveInjuryRecord = new System.Windows.Forms.Button();
            this.dtpInjuryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpectedReturn = new System.Windows.Forms.DateTimePicker();
            this.txtInjuryNotes = new System.Windows.Forms.TextBox();
            this.txtInjuryType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInjuryAthlete = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLogOutTrack = new System.Windows.Forms.Button();
            this.txtClearanceNotes = new System.Windows.Forms.TextBox();
            this.btnDischargePlayer = new System.Windows.Forms.Button();
            this.btnUpdateRecoveryStatus = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbNewRecoveryStatus = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSelectActiveInjury = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbMedicalReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerateMedicalReport = new System.Windows.Forms.Button();
            this.dgvMedicalReportResults = new System.Windows.Forms.DataGridView();
            this.btnLogOutReports = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStaffCountVal = new System.Windows.Forms.Label();
            this.lblTotalAthletesVal = new System.Windows.Forms.Label();
            this.lblOverdueVal = new System.Windows.Forms.Label();
            this.lblClearedMonthVal = new System.Windows.Forms.Label();
            this.lblNewInjuriesVal = new System.Windows.Forms.Label();
            this.lblCommonInjuryVal = new System.Windows.Forms.Label();
            this.lblAvgRecoveryVal = new System.Windows.Forms.Label();
            this.lblTotalInjuredVal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalReportResults)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLogOutProfile);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtMedicalCertID);
            this.tabPage1.Controls.Add(this.txtMedicalSpecialty);
            this.tabPage1.Controls.Add(this.txtMedicalName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnLogOutProfile
            // 
            this.btnLogOutProfile.Location = new System.Drawing.Point(708, 393);
            this.btnLogOutProfile.Name = "btnLogOutProfile";
            this.btnLogOutProfile.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutProfile.TabIndex = 7;
            this.btnLogOutProfile.Text = "Logout";
            this.btnLogOutProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMedicalUpdatePass);
            this.groupBox1.Controls.Add(this.txtMedicalConfirmPass);
            this.groupBox1.Controls.Add(this.txtMedicalNewPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(338, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Security";
            // 
            // btnMedicalUpdatePass
            // 
            this.btnMedicalUpdatePass.Location = new System.Drawing.Point(71, 98);
            this.btnMedicalUpdatePass.Name = "btnMedicalUpdatePass";
            this.btnMedicalUpdatePass.Size = new System.Drawing.Size(124, 23);
            this.btnMedicalUpdatePass.TabIndex = 4;
            this.btnMedicalUpdatePass.Text = "Update Password";
            this.btnMedicalUpdatePass.UseVisualStyleBackColor = true;
            this.btnMedicalUpdatePass.Click += new System.EventHandler(this.btnMedicalUpdatePass_Click);
            // 
            // txtMedicalConfirmPass
            // 
            this.txtMedicalConfirmPass.Location = new System.Drawing.Point(117, 54);
            this.txtMedicalConfirmPass.Name = "txtMedicalConfirmPass";
            this.txtMedicalConfirmPass.PasswordChar = '*';
            this.txtMedicalConfirmPass.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalConfirmPass.TabIndex = 3;
            // 
            // txtMedicalNewPass
            // 
            this.txtMedicalNewPass.Location = new System.Drawing.Point(117, 28);
            this.txtMedicalNewPass.Name = "txtMedicalNewPass";
            this.txtMedicalNewPass.PasswordChar = '*';
            this.txtMedicalNewPass.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalNewPass.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Password:";
            // 
            // txtMedicalCertID
            // 
            this.txtMedicalCertID.Location = new System.Drawing.Point(109, 130);
            this.txtMedicalCertID.Name = "txtMedicalCertID";
            this.txtMedicalCertID.ReadOnly = true;
            this.txtMedicalCertID.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalCertID.TabIndex = 5;
            // 
            // txtMedicalSpecialty
            // 
            this.txtMedicalSpecialty.Location = new System.Drawing.Point(106, 82);
            this.txtMedicalSpecialty.Name = "txtMedicalSpecialty";
            this.txtMedicalSpecialty.ReadOnly = true;
            this.txtMedicalSpecialty.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalSpecialty.TabIndex = 4;
            // 
            // txtMedicalName
            // 
            this.txtMedicalName.Location = new System.Drawing.Point(106, 40);
            this.txtMedicalName.Name = "txtMedicalName";
            this.txtMedicalName.ReadOnly = true;
            this.txtMedicalName.Size = new System.Drawing.Size(100, 20);
            this.txtMedicalName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Certification ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Specialty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLogOutRecord);
            this.tabPage2.Controls.Add(this.btnSaveInjuryRecord);
            this.tabPage2.Controls.Add(this.dtpInjuryDate);
            this.tabPage2.Controls.Add(this.dtpExpectedReturn);
            this.tabPage2.Controls.Add(this.txtInjuryNotes);
            this.tabPage2.Controls.Add(this.txtInjuryType);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cmbInjuryAthlete);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Record New Injury";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogOutRecord
            // 
            this.btnLogOutRecord.Location = new System.Drawing.Point(699, 393);
            this.btnLogOutRecord.Name = "btnLogOutRecord";
            this.btnLogOutRecord.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutRecord.TabIndex = 11;
            this.btnLogOutRecord.Text = "Logout";
            this.btnLogOutRecord.UseVisualStyleBackColor = true;
            // 
            // btnSaveInjuryRecord
            // 
            this.btnSaveInjuryRecord.Location = new System.Drawing.Point(280, 222);
            this.btnSaveInjuryRecord.Name = "btnSaveInjuryRecord";
            this.btnSaveInjuryRecord.Size = new System.Drawing.Size(106, 23);
            this.btnSaveInjuryRecord.TabIndex = 10;
            this.btnSaveInjuryRecord.Text = "Save Injury Record";
            this.btnSaveInjuryRecord.UseVisualStyleBackColor = true;
            this.btnSaveInjuryRecord.Click += new System.EventHandler(this.btnSaveInjuryRecord_Click);
            // 
            // dtpInjuryDate
            // 
            this.dtpInjuryDate.Location = new System.Drawing.Point(513, 34);
            this.dtpInjuryDate.Name = "dtpInjuryDate";
            this.dtpInjuryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpInjuryDate.TabIndex = 9;
            // 
            // dtpExpectedReturn
            // 
            this.dtpExpectedReturn.Location = new System.Drawing.Point(513, 85);
            this.dtpExpectedReturn.Name = "dtpExpectedReturn";
            this.dtpExpectedReturn.Size = new System.Drawing.Size(200, 20);
            this.dtpExpectedReturn.TabIndex = 8;
            // 
            // txtInjuryNotes
            // 
            this.txtInjuryNotes.Location = new System.Drawing.Point(103, 126);
            this.txtInjuryNotes.Multiline = true;
            this.txtInjuryNotes.Name = "txtInjuryNotes";
            this.txtInjuryNotes.Size = new System.Drawing.Size(100, 20);
            this.txtInjuryNotes.TabIndex = 7;
            // 
            // txtInjuryType
            // 
            this.txtInjuryType.Location = new System.Drawing.Point(103, 82);
            this.txtInjuryType.Name = "txtInjuryType";
            this.txtInjuryType.Size = new System.Drawing.Size(100, 20);
            this.txtInjuryType.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Initial Notes: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Expected Recovery Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date of Injury:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Injury Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Athlete Name:";
            // 
            // cmbInjuryAthlete
            // 
            this.cmbInjuryAthlete.FormattingEnabled = true;
            this.cmbInjuryAthlete.Location = new System.Drawing.Point(103, 31);
            this.cmbInjuryAthlete.Name = "cmbInjuryAthlete";
            this.cmbInjuryAthlete.Size = new System.Drawing.Size(121, 21);
            this.cmbInjuryAthlete.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLogOutTrack);
            this.tabPage3.Controls.Add(this.txtClearanceNotes);
            this.tabPage3.Controls.Add(this.btnDischargePlayer);
            this.tabPage3.Controls.Add(this.btnUpdateRecoveryStatus);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cmbNewRecoveryStatus);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.cmbSelectActiveInjury);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(794, 427);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recovery Tracking";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLogOutTrack
            // 
            this.btnLogOutTrack.Location = new System.Drawing.Point(708, 398);
            this.btnLogOutTrack.Name = "btnLogOutTrack";
            this.btnLogOutTrack.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutTrack.TabIndex = 8;
            this.btnLogOutTrack.Text = "Logout";
            this.btnLogOutTrack.UseVisualStyleBackColor = true;
            this.btnLogOutTrack.Click += new System.EventHandler(this.btnMedicalLogout_Click);
            // 
            // txtClearanceNotes
            // 
            this.txtClearanceNotes.Location = new System.Drawing.Point(490, 40);
            this.txtClearanceNotes.Multiline = true;
            this.txtClearanceNotes.Name = "txtClearanceNotes";
            this.txtClearanceNotes.Size = new System.Drawing.Size(100, 20);
            this.txtClearanceNotes.TabIndex = 7;
            // 
            // btnDischargePlayer
            // 
            this.btnDischargePlayer.Location = new System.Drawing.Point(248, 198);
            this.btnDischargePlayer.Name = "btnDischargePlayer";
            this.btnDischargePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnDischargePlayer.TabIndex = 6;
            this.btnDischargePlayer.Text = "Clear Player";
            this.btnDischargePlayer.UseVisualStyleBackColor = true;
            this.btnDischargePlayer.Click += new System.EventHandler(this.btnDischargePlayer_Click);
            // 
            // btnUpdateRecoveryStatus
            // 
            this.btnUpdateRecoveryStatus.Location = new System.Drawing.Point(65, 198);
            this.btnUpdateRecoveryStatus.Name = "btnUpdateRecoveryStatus";
            this.btnUpdateRecoveryStatus.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRecoveryStatus.TabIndex = 5;
            this.btnUpdateRecoveryStatus.Text = "Update Status";
            this.btnUpdateRecoveryStatus.UseVisualStyleBackColor = true;
            this.btnUpdateRecoveryStatus.Click += new System.EventHandler(this.btnUpdateRecoveryStatus_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Medical Clearance Notes:";
            // 
            // cmbNewRecoveryStatus
            // 
            this.cmbNewRecoveryStatus.FormattingEnabled = true;
            this.cmbNewRecoveryStatus.Items.AddRange(new object[] {
            "Rehabilitating",
            "Light Training",
            "Full Contact Training",
            "Cleared for Matches"});
            this.cmbNewRecoveryStatus.Location = new System.Drawing.Point(133, 83);
            this.cmbNewRecoveryStatus.Name = "cmbNewRecoveryStatus";
            this.cmbNewRecoveryStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbNewRecoveryStatus.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Update Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Select Injury:";
            // 
            // cmbSelectActiveInjury
            // 
            this.cmbSelectActiveInjury.FormattingEnabled = true;
            this.cmbSelectActiveInjury.Location = new System.Drawing.Point(133, 37);
            this.cmbSelectActiveInjury.Name = "cmbSelectActiveInjury";
            this.cmbSelectActiveInjury.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectActiveInjury.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Controls.Add(this.btnLogOutReports);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(794, 427);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Medical Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.cmbMedicalReportType);
            this.groupBox3.Controls.Add(this.btnGenerateMedicalReport);
            this.groupBox3.Controls.Add(this.dgvMedicalReportResults);
            this.groupBox3.Location = new System.Drawing.Point(35, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 189);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detailed Reports";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Report Type:";
            // 
            // cmbMedicalReportType
            // 
            this.cmbMedicalReportType.FormattingEnabled = true;
            this.cmbMedicalReportType.Items.AddRange(new object[] {
            "Full Injury History",
            "Cleared Players List",
            "Upcoming Medical Checks"});
            this.cmbMedicalReportType.Location = new System.Drawing.Point(91, 41);
            this.cmbMedicalReportType.Name = "cmbMedicalReportType";
            this.cmbMedicalReportType.Size = new System.Drawing.Size(121, 21);
            this.cmbMedicalReportType.TabIndex = 1;
            // 
            // btnGenerateMedicalReport
            // 
            this.btnGenerateMedicalReport.Location = new System.Drawing.Point(45, 106);
            this.btnGenerateMedicalReport.Name = "btnGenerateMedicalReport";
            this.btnGenerateMedicalReport.Size = new System.Drawing.Size(114, 38);
            this.btnGenerateMedicalReport.TabIndex = 2;
            this.btnGenerateMedicalReport.Text = "Generate Detailed Report";
            this.btnGenerateMedicalReport.UseVisualStyleBackColor = true;
            this.btnGenerateMedicalReport.Click += new System.EventHandler(this.btnGenerateMedicalReport_Click);
            // 
            // dgvMedicalReportResults
            // 
            this.dgvMedicalReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalReportResults.Location = new System.Drawing.Point(236, 14);
            this.dgvMedicalReportResults.Name = "dgvMedicalReportResults";
            this.dgvMedicalReportResults.RowHeadersWidth = 51;
            this.dgvMedicalReportResults.Size = new System.Drawing.Size(240, 150);
            this.dgvMedicalReportResults.TabIndex = 3;
            // 
            // btnLogOutReports
            // 
            this.btnLogOutReports.Location = new System.Drawing.Point(709, 393);
            this.btnLogOutReports.Name = "btnLogOutReports";
            this.btnLogOutReports.Size = new System.Drawing.Size(75, 23);
            this.btnLogOutReports.TabIndex = 4;
            this.btnLogOutReports.Text = "Logout";
            this.btnLogOutReports.UseVisualStyleBackColor = true;
            this.btnLogOutReports.Click += new System.EventHandler(this.btnMedicalLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStaffCountVal);
            this.groupBox2.Controls.Add(this.lblTotalAthletesVal);
            this.groupBox2.Controls.Add(this.lblOverdueVal);
            this.groupBox2.Controls.Add(this.lblClearedMonthVal);
            this.groupBox2.Controls.Add(this.lblNewInjuriesVal);
            this.groupBox2.Controls.Add(this.lblCommonInjuryVal);
            this.groupBox2.Controls.Add(this.lblAvgRecoveryVal);
            this.groupBox2.Controls.Add(this.lblTotalInjuredVal);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(21, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 190);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Managerial Section";
            // 
            // lblStaffCountVal
            // 
            this.lblStaffCountVal.AutoSize = true;
            this.lblStaffCountVal.Location = new System.Drawing.Point(390, 143);
            this.lblStaffCountVal.Name = "lblStaffCountVal";
            this.lblStaffCountVal.Size = new System.Drawing.Size(41, 13);
            this.lblStaffCountVal.TabIndex = 15;
            this.lblStaffCountVal.Text = "label29";
            // 
            // lblTotalAthletesVal
            // 
            this.lblTotalAthletesVal.AutoSize = true;
            this.lblTotalAthletesVal.Location = new System.Drawing.Point(390, 101);
            this.lblTotalAthletesVal.Name = "lblTotalAthletesVal";
            this.lblTotalAthletesVal.Size = new System.Drawing.Size(41, 13);
            this.lblTotalAthletesVal.TabIndex = 14;
            this.lblTotalAthletesVal.Text = "label28";
            // 
            // lblOverdueVal
            // 
            this.lblOverdueVal.AutoSize = true;
            this.lblOverdueVal.Location = new System.Drawing.Point(390, 66);
            this.lblOverdueVal.Name = "lblOverdueVal";
            this.lblOverdueVal.Size = new System.Drawing.Size(41, 13);
            this.lblOverdueVal.TabIndex = 13;
            this.lblOverdueVal.Text = "label27";
            // 
            // lblClearedMonthVal
            // 
            this.lblClearedMonthVal.AutoSize = true;
            this.lblClearedMonthVal.Location = new System.Drawing.Point(390, 31);
            this.lblClearedMonthVal.Name = "lblClearedMonthVal";
            this.lblClearedMonthVal.Size = new System.Drawing.Size(41, 13);
            this.lblClearedMonthVal.TabIndex = 12;
            this.lblClearedMonthVal.Text = "label26";
            // 
            // lblNewInjuriesVal
            // 
            this.lblNewInjuriesVal.AutoSize = true;
            this.lblNewInjuriesVal.Location = new System.Drawing.Point(153, 143);
            this.lblNewInjuriesVal.Name = "lblNewInjuriesVal";
            this.lblNewInjuriesVal.Size = new System.Drawing.Size(41, 13);
            this.lblNewInjuriesVal.TabIndex = 11;
            this.lblNewInjuriesVal.Text = "label25";
            // 
            // lblCommonInjuryVal
            // 
            this.lblCommonInjuryVal.AutoSize = true;
            this.lblCommonInjuryVal.Location = new System.Drawing.Point(151, 101);
            this.lblCommonInjuryVal.Name = "lblCommonInjuryVal";
            this.lblCommonInjuryVal.Size = new System.Drawing.Size(41, 13);
            this.lblCommonInjuryVal.TabIndex = 10;
            this.lblCommonInjuryVal.Text = "label24";
            // 
            // lblAvgRecoveryVal
            // 
            this.lblAvgRecoveryVal.AutoSize = true;
            this.lblAvgRecoveryVal.Location = new System.Drawing.Point(151, 65);
            this.lblAvgRecoveryVal.Name = "lblAvgRecoveryVal";
            this.lblAvgRecoveryVal.Size = new System.Drawing.Size(41, 13);
            this.lblAvgRecoveryVal.TabIndex = 9;
            this.lblAvgRecoveryVal.Text = "label23";
            // 
            // lblTotalInjuredVal
            // 
            this.lblTotalInjuredVal.AutoSize = true;
            this.lblTotalInjuredVal.Location = new System.Drawing.Point(151, 31);
            this.lblTotalInjuredVal.Name = "lblTotalInjuredVal";
            this.lblTotalInjuredVal.Size = new System.Drawing.Size(41, 13);
            this.lblTotalInjuredVal.TabIndex = 8;
            this.lblTotalInjuredVal.Text = "label22";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(246, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(136, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Medical Staff Active Count:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(246, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "Total Athletes in Hub";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(246, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Overdue Recoveries";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(246, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Players Cleared this Month:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "New Injuries (Month):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Most Common Injury Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Avg Recovery Time (Days):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Currently Injured:";
            // 
            // Medical_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Medical_Dashboard";
            this.Text = "Medical_Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalReportResults)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMedicalSpecialty;
        private System.Windows.Forms.TextBox txtMedicalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMedicalUpdatePass;
        private System.Windows.Forms.TextBox txtMedicalConfirmPass;
        private System.Windows.Forms.TextBox txtMedicalNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedicalCertID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbInjuryAthlete;
        private System.Windows.Forms.Button btnLogOutProfile;
        private System.Windows.Forms.Button btnLogOutRecord;
        private System.Windows.Forms.Button btnSaveInjuryRecord;
        private System.Windows.Forms.DateTimePicker dtpInjuryDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedReturn;
        private System.Windows.Forms.TextBox txtInjuryNotes;
        private System.Windows.Forms.TextBox txtInjuryType;
        private System.Windows.Forms.Button btnLogOutTrack;
        private System.Windows.Forms.TextBox txtClearanceNotes;
        private System.Windows.Forms.Button btnDischargePlayer;
        private System.Windows.Forms.Button btnUpdateRecoveryStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbNewRecoveryStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSelectActiveInjury;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnLogOutReports;
        private System.Windows.Forms.DataGridView dgvMedicalReportResults;
        private System.Windows.Forms.Button btnGenerateMedicalReport;
        private System.Windows.Forms.ComboBox cmbMedicalReportType;
        private System.Windows.Forms.Label lblStaffCountVal;
        private System.Windows.Forms.Label lblTotalAthletesVal;
        private System.Windows.Forms.Label lblOverdueVal;
        private System.Windows.Forms.Label lblClearedMonthVal;
        private System.Windows.Forms.Label lblNewInjuriesVal;
        private System.Windows.Forms.Label lblCommonInjuryVal;
        private System.Windows.Forms.Label lblAvgRecoveryVal;
        private System.Windows.Forms.Label lblTotalInjuredVal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
    }
}