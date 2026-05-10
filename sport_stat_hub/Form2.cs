using DBapplication;
using System;
using System.Data;
using System.Windows.Forms;

namespace sport_stat_hub
{
    public partial class Form2 : Form
    {
        DBManager dbManager;

        public Form2()
        {
            InitializeComponent();
            string connStr = @"Data Source=.;Initial Catalog=Sports_Hub;Integrated Security=True;TrustServerCertificate=True";
            dbManager = new DBManager(connStr);

            comboBox3.Items.Clear();
            comboBox3.Items.Add("Athlete");
            comboBox3.Items.Add("Coach");
            comboBox3.SelectedIndex = 0;

            comboBox4.Items.Clear();
            comboBox4.Items.Add("League Rankings");
            comboBox4.Items.Add("Stadium Capacities"); 
            comboBox4.Items.Add("Injury History");
            comboBox4.Items.Add("System Coaches");

            PopulateLeagueDropdown();
            RefreshContractList();
            RefreshUserList();
        }


        public void RefreshUserList()
        {
            try
            {
              
                DataTable dt = dbManager.ExecuteReader(@"
            SELECT 'Athlete' AS [Role], AthleteID AS [ID], AthleteName AS [Name] FROM Athlete
            UNION
            SELECT 'Coach', CoachID, CoachName FROM Coach
            UNION
            SELECT 'MedicalStaff', StaffID, StaffName FROM MedicalStaff
            UNION
            SELECT 'Admin', AdminID, AdminName FROM Admin");

             
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Refresh Error: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            MessageBox.Show("1. The Load Event is running!");

            try
            {
                DataTable dt = dbManager.ExecuteReader(@"
            SELECT 'Athlete' AS [Role], AthleteID AS [ID], AthleteName AS [Name] FROM Athlete
            UNION
            SELECT 'Coach', CoachID, CoachName FROM Coach
            UNION
            SELECT 'MedicalStaff', StaffID, StaffName FROM MedicalStaff
            UNION
            SELECT 'Admin', AdminID, AdminName FROM Admin");

               
                MessageBox.Show("2. SQL found " + dt.Rows.Count + " rows.");

                if (dataGridView1 == null)
                {
                    MessageBox.Show("3. ERROR: dataGridView1 does not exist in code!");
                }
                else
                {
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("4. Data assigned to " + dataGridView1.Name);

                 
                    MessageBox.Show("5. Parent of box is: " + dataGridView1.Parent.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text;
            string password = textBox2.Text;
            string userType = comboBox1.Text.Trim();

            Random rnd = new Random();
            int newID = rnd.Next(1000, 9999);

            string query = "";

            if (userType == "Athlete")
                query = $"INSERT INTO Athlete (AthleteID, AthleteName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            else if (userType == "Coach")
                query = $"INSERT INTO Coach (CoachID, CoachName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            else if (userType == "MedicalStaff")
                query = $"INSERT INTO MedicalStaff (StaffID, StaffName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            else if (userType == "Admin")
                query = $"INSERT INTO Admin (AdminID, AdminName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";

            if (query != "")
            {
                try
                {
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show($"Success! {userType} registered.\nID: {newID}");

                    // --- ADD THIS LINE HERE ---
                    RefreshUserList();

                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Get inputs
            string name = textBox5.Text;
            string country = textBox6.Text;
            string division = textBox7.Text;

            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Please enter a League Name"); return; }

            // 2. Generate ID
            Random rnd = new Random();
            int id = rnd.Next(10, 500);

            // 3. SQL Query
            string query = $"INSERT INTO League (LeagueID, LeagueName, Country, Division) " +
                           $"VALUES ({id}, '{name}', '{country}', '{division}')";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"League '{name}' created successfully!");

                // Clear boxes
                textBox5.Clear(); textBox6.Clear(); textBox7.Clear();

                // After adding a league, we should refresh the Team's dropdown
                PopulateLeagueDropdown();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void PopulateLeagueDropdown()
        {
            try
            {
                // This gets the names of all leagues you have created
                DataTable dt = dbManager.ExecuteReader("SELECT LeagueID, LeagueName FROM League");

                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "LeagueName"; // This is what the user sees
                comboBox2.ValueMember = "LeagueID";     // This is the hidden ID we send to SQL
            }
            catch (Exception ex)
            {
                // We use Console.WriteLine so it doesn't annoy the user if it's empty at first
                Console.WriteLine("Dropdown error: " + ex.Message);
            }
        }


        //private void ComboBox2()
        //{
        //    throw new NotImplementedException();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            string teamName = textBox8.Text;
            string city = textBox9.Text;

            // Check if they actually picked a league
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please create and select a League first!");
                return;
            }

            // Get the ID of the league selected in the dropdown
            int selectedLeagueID = Convert.ToInt32(comboBox2.SelectedValue);

            Random rnd = new Random();
            int teamID = rnd.Next(10, 1000);

            string query = $"INSERT INTO Team (TeamID, TeamName, City, LeagueID) " +
                           $"VALUES ({teamID}, '{teamName}', '{city}', {selectedLeagueID})";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"Team '{teamName}' registered successfully!");
                textBox8.Clear(); textBox9.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string venueName = textBox10.Text;
            string capacity = textBox11.Text;

            Random rnd = new Random();
            int id = rnd.Next(10, 1000);

            // Notice we include 'Capacity' in the query now
            string query = $"INSERT INTO Stadium (StadiumID, StadiumName, Location, Capacity) " +
                           $"VALUES ({id}, '{venueName}', 'Local', {capacity})";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show("Stadium added successfully!");
                textBox10.Clear(); textBox11.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            // 1. Collect inputs
            string role = comboBox3.Text;
            string personID = textBox3.Text;
            decimal salary = numericUpDown1.Value;
            string buyout = textBox12.Text;

            // Combine dates into the 'Terms' string
            string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string end = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            string terms = $"Dates: {start} to {end}. Buyout: ${buyout}";

            if (string.IsNullOrEmpty(personID))
            {
                MessageBox.Show("Please enter the ID of the Athlete or Coach!");
                return;
            }

            // 2. Generate Contract ID
            Random rnd = new Random();
            int contractID = rnd.Next(1000, 9999);

            // 3. Build SQL based on Role
            string query = "";
            if (role == "Athlete")
            {
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID, WeeklySalary) " +
                        $"VALUES ({contractID}, '{terms}', {personID}, NULL, {salary})";
            }
            else
            {
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID, WeeklySalary) " +
                        $"VALUES ({contractID}, '{terms}', NULL, {personID}, {salary})";
            }

            // 4. Execute
            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"Contract signed successfully for {role} ID: {personID}!");

                // Refresh the list instantly
                RefreshContractList();

                // Clear boxes
                textBox3.Clear(); textBox12.Clear(); numericUpDown1.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Make sure the ID exists in the system!\n" + ex.Message);
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label20.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Athlete").ToString();

                // FIX: Point this to the WeeklySalary column in the Contract table
                label21.Text = "$" + dbManager.ExecuteScalar("SELECT ISNULL(AVG(WeeklySalary),0) FROM Contract").ToString();

                label22.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Team").ToString();
                label23.Text = dbManager.ExecuteScalar("SELECT MAX(Capacity) FROM Stadium").ToString();
                label24.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM InjuryRecord WHERE Status='Active'").ToString();
                label25.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Contract").ToString();
                label26.Text = dbManager.ExecuteScalar("SELECT ISNULL(SUM(Attendance), 0) FROM Match").ToString();
                label27.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM League").ToString();


                MessageBox.Show("Dashboard Updated!");
            }
            catch (Exception ex) { MessageBox.Show("Dashboard Error: " + ex.Message); }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear old columns first to ensure the new ones appear correctly
            dataGridView3.DataSource = null;
            dataGridView3.Columns.Clear();

            string query = "";

            // IMPORTANT: These names must match EXACTLY what you put in the Constructor
            if (comboBox4.Text == "Stadium Capacities")
            {
                query = "SELECT StadiumName AS [Venue], Location, Capacity FROM Stadium ORDER BY Capacity DESC";
            }
            else if (comboBox4.Text == "League Rankings")
            {
                query = "SELECT TeamName, TotalWins FROM Team ORDER BY TotalWins DESC";
            }
            else if (comboBox4.Text == "System Coaches")
            {
                query = "SELECT CoachName, TacticsPreference FROM Coach";
            }
            else if (comboBox4.Text == "Injury History")
            {
                query = "SELECT A.AthleteName, I.Details, I.Status FROM InjuryRecord I JOIN Athlete A ON I.AthleteID = A.AthleteID";
            }

            if (query != "")
            {
                try
                {
                    DataTable dt = dbManager.ExecuteReader(query);
                    dataGridView3.AutoGenerateColumns = true; // This forces the "Capacity" column to appear
                    dataGridView3.DataSource = dt;
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report exported (Simulated).");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshContractList()
        {
            try
            {
                // This query joins the Contract table with Athlete and Coach to show names
                string query = @"
            SELECT 
                C.ContractID AS [ID], 
                ISNULL(A.AthleteName, CO.CoachName) AS [Name],
                CASE WHEN C.AthleteID IS NOT NULL THEN 'Athlete' ELSE 'Coach' END AS [Role],
                C.WeeklySalary AS [Salary ($)],
                C.Terms
            FROM Contract C
            LEFT JOIN Athlete A ON C.AthleteID = A.AthleteID
            LEFT JOIN Coach CO ON C.CoachID = CO.CoachID";

                DataTable dt = dbManager.ExecuteReader(query);

                // Ensure this name matches the gray box on Tab 3 in your Designer
                dataGridView2.DataSource = dt;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) { Console.WriteLine("Contract List Error: " + ex.Message); }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}