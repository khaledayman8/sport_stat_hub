using System;
using System.Data;
using System.Windows.Forms;
using DBapplication;

namespace sport_stat_hub
{
    public partial class Medical_Dashboard : Form
    {
        Controller controllerObj;
        int currentStaffID;

        public Medical_Dashboard(int staffID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            currentStaffID = staffID;
            LoadMedicalData();
        }

        private void LoadMedicalData()
        {
            try
            {
             
                DataTable dt = controllerObj.GetMedicalProfile(currentStaffID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    txtMedicalName.Text = dt.Rows[0]["StaffName"].ToString();
                    txtMedicalSpecialty.Text = dt.Rows[0]["Specialty"].ToString();
                    txtMedicalCertID.Text = dt.Rows[0]["CertificationID"].ToString();
                }

              
                cmbInjuryAthlete.DataSource = controllerObj.GetAthletesList(1);
                cmbInjuryAthlete.DisplayMember = "AthleteName";
                cmbInjuryAthlete.ValueMember = "AthleteID";

                cmbSelectActiveInjury.DataSource = controllerObj.GetActiveInjuriesList();
                cmbSelectActiveInjury.DisplayMember = "Display";
                cmbSelectActiveInjury.ValueMember = "RecordID";

             
                DataTable dtStats = controllerObj.GetMedicalManagerialStats();
                if (dtStats != null && dtStats.Rows.Count > 0)
                {
                    lblTotalInjuredVal.Text = dtStats.Rows[0]["TotalInjured"].ToString();
                    lblAvgRecoveryVal.Text = dtStats.Rows[0]["AvgRecovery"].ToString() + " Days";
                    lblCommonInjuryVal.Text = dtStats.Rows[0]["CommonInjury"].ToString();
                    lblClearedMonthVal.Text = dtStats.Rows[0]["TotalCleared"].ToString();
                    lblStaffCountVal.Text = dtStats.Rows[0]["StaffCount"].ToString();

                   
                    lblNewInjuriesVal.Text = dtStats.Rows[0]["NewInjuries"].ToString();
                    lblOverdueVal.Text = dtStats.Rows[0]["Overdue"].ToString();
                    lblTotalAthletesVal.Text = dtStats.Rows[0]["TotalAthletes"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
       
        private void btnSaveInjuryRecord_Click(object sender, EventArgs e)
        {
            int athleteId = Convert.ToInt32(cmbInjuryAthlete.SelectedValue);
            int r = controllerObj.AddInjuryRecord(currentStaffID, athleteId, txtInjuryType.Text,
                    dtpInjuryDate.Value.ToString("yyyy-MM-dd"), dtpExpectedReturn.Value.ToString("yyyy-MM-dd"), txtInjuryNotes.Text);
            if (r > 0) MessageBox.Show("Injury Record Saved!");
        }

       
        private void btnUpdateRecoveryStatus_Click(object sender, EventArgs e)
        {
            int recordId = Convert.ToInt32(cmbSelectActiveInjury.SelectedValue);
            string status = cmbNewRecoveryStatus.SelectedItem.ToString();
            int r = controllerObj.UpdateRecoveryStatus(recordId, status, txtClearanceNotes.Text);
            if (r > 0) MessageBox.Show("Recovery Progress Updated!");
        }

       
        private void btnGenerateMedicalReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbMedicalReportType.SelectedItem.ToString();
            dgvMedicalReportResults.DataSource = controllerObj.GetMedicalDetailedReport(reportType);
        }

        private void btnMedicalLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show(); 
        }

        private void btnDischargePlayer_Click(object sender, EventArgs e)
        {
            if (cmbSelectActiveInjury.SelectedValue == null) return;

            int recordId = Convert.ToInt32(cmbSelectActiveInjury.SelectedValue);
            int r = controllerObj.DischargePlayer(recordId);

            if (r > 0)
            {
                MessageBox.Show("Player cleared and marked as Recovered!");
                LoadMedicalData(); 
            }
        }

        private void btnMedicalUpdatePass_Click(object sender, EventArgs e)
        {
            if (txtMedicalNewPass.Text == txtMedicalConfirmPass.Text && !string.IsNullOrWhiteSpace(txtMedicalNewPass.Text))
            {
                int r = controllerObj.ChangeMedicalPassword(currentStaffID, txtMedicalNewPass.Text);
                if (r > 0) MessageBox.Show("Password updated successfully!");
            }
            else
            {
                MessageBox.Show("Passwords do not match or are empty!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}