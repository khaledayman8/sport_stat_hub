using System;
using System.Data;
using System.Windows.Forms;
using DBapplication;

namespace sport_stat_hub
{
    public partial class CoachDashboard : Form
    {
        Controller controllerObj;
        int currentCoachID;
        int currentTeamID;

        public CoachDashboard(int coachID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            currentCoachID = coachID;

            currentTeamID = controllerObj.GetTeamIDFromCoach(currentCoachID);

            LoadAllDashboardData();
        }

        private void LoadAllDashboardData()
        {
            try
            {
               
                DataTable dtProfile = controllerObj.GetCoachProfile(currentCoachID);
                if (dtProfile != null && dtProfile.Rows.Count > 0)
                {
                    txtCoachName.Text = dtProfile.Rows[0]["CoachName"].ToString();
                    txtLicenseLevel.Text = dtProfile.Rows[0]["LicenseLevel"].ToString();
                    txtTactics.Text = dtProfile.Rows[0]["TacticsPreference"].ToString();
                }

               
                dgvMyTeam.DataSource = controllerObj.GetMyTeamAthletes(currentCoachID);

                DataTable dtStats = controllerObj.GetTeamManagerialStats(currentTeamID);
                if (dtStats != null && dtStats.Rows.Count > 0)
                {
                    lblWinRateValue.Text = dtStats.Rows[0]["WinRate"].ToString() + "%";
                    lblTotalGoalsValue.Text = dtStats.Rows[0]["TotalGoals"].ToString();
                    lblTotalWinsValue.Text = dtStats.Rows[0]["TotalWins"].ToString();
                    lblCleanSheetsValue.Text = dtStats.Rows[0]["CleanSheets"].ToString();
                    lblTotalPointsValue.Text = dtStats.Rows[0]["TotalPoints"].ToString();
                    lblInjuryCountValue.Text = dtStats.Rows[0]["InjuryCount"].ToString();
                    lblGoalsPerGameValue.Text = dtStats.Rows[0]["GoalsPerGame"].ToString();
                    lblTotalAssistsValue.Text = dtStats.Rows[0]["TotalAssists"].ToString();
                }

               
                cmbSelectMatch.DataSource = controllerObj.GetMatchesList();
                cmbSelectMatch.DisplayMember = "Display";
                cmbSelectMatch.ValueMember = "MatchID";

                cmbSelectAthlete.DataSource = controllerObj.GetAthletesList(currentTeamID);
                cmbSelectAthlete.DisplayMember = "AthleteName";
                cmbSelectAthlete.ValueMember = "AthleteID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            int r = controllerObj.UpdateCoachProfile(currentCoachID, txtLicenseLevel.Text, txtTactics.Text);
            if (r > 0) MessageBox.Show("Profile Updated!");
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmPassword.Text && !string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                controllerObj.ChangeCoachPassword(currentCoachID, txtNewPassword.Text);
                MessageBox.Show("Password Changed Successfully!");
            }
            else { MessageBox.Show("Passwords do not match!"); }
        }

        private void btnAddTrainingSession_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddTrainingSession(currentTeamID, dtpTrainingDate.Value);
            if (r > 0) MessageBox.Show("Training session added!");
        }

        private void btnSavePerformance_Click(object sender, EventArgs e)
        {
            if (cmbSelectMatch.SelectedValue == null || cmbSelectAthlete.SelectedValue == null) return;

            int matchId = Convert.ToInt32(cmbSelectMatch.SelectedValue);
            int athleteId = Convert.ToInt32(cmbSelectAthlete.SelectedValue);

            int r = controllerObj.RecordAthletePerformance(matchId, athleteId, (int)numGoals.Value, (int)numAssists.Value, (int)numYellowCards.Value, (int)numMinutesPlayed.Value);
            if (r > 0) MessageBox.Show("Match stats saved!");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportSelector.SelectedItem == null) return;
            string choice = cmbReportSelector.SelectedItem.ToString();

            if (choice == "Squad Top Scorers")
                dgvReportResults.DataSource = controllerObj.GetTopScorers(currentTeamID);
            else if (choice == "Full Injury List")
                dgvReportResults.DataSource = controllerObj.GetTeamInjuryList(currentTeamID);
            else if (choice == "Training Attendance")
            {
               
                dgvReportResults.DataSource = controllerObj.GetFullTeamAttendance(currentTeamID);
            }
        }

        private void PerformLogout() { this.Hide(); new Form1().Show(); }
        private void btnLogout_Click(object sender, EventArgs e) { PerformLogout(); }
        private void btnLogoutProfile_Click(object sender, EventArgs e) { PerformLogout(); }
        private void btnLogoutTeam_Click(object sender, EventArgs e) { PerformLogout(); }
        private void btnLogoutTraining_Click(object sender, EventArgs e) { PerformLogout(); }
        private void btnLogoutStats_Click(object sender, EventArgs e) { PerformLogout(); }
        private void btnLogoutReport_Click(object sender, EventArgs e) { PerformLogout(); }

        private void cmbReportSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoachDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}