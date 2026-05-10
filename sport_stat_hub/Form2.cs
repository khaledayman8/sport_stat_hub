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

         
            MessageBox.Show("1. Form2 Constructor is running!");

         
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
            string userType = comboBox1.Text;

            Random rnd = new Random();
            int newID = rnd.Next(100, 1000);

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
            Random rnd = new Random();
            int id = rnd.Next(10, 1000);
            string query = $"INSERT INTO League (LeagueID, LeagueName, Country, Division) VALUES ({id}, '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}')";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"League '{textBox5.Text}' created successfully!");
                textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10, 1000);
            string query = $"INSERT INTO Team (TeamID, TeamName, City, LeagueID) VALUES ({id}, '{textBox8.Text}', '{textBox9.Text}', 1)";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"Team '{textBox8.Text}' registered!");
                textBox8.Clear(); textBox9.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10, 1000);
           
            string query = $"INSERT INTO Stadium (StadiumID, StadiumName, Location, Capacity) VALUES ({id}, '{textBox10.Text}', 'Local City', {textBox11.Text})";

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
            string role = comboBox3.Text;
            string pID = textBox3.Text;
            string salary = numericUpDown1.Value.ToString();
            string start = dateTimePicker1.Value.ToShortDateString();
            string end = dateTimePicker2.Value.ToShortDateString();
            string terms = $"Salary: ${salary}/week. Dates: {start} to {end}";

            Random rnd = new Random();
            int contractID = rnd.Next(1000, 9999);
            string query = "";

            if (role == "Athlete")
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID, WeeklySalary) VALUES ({contractID}, '{terms}', {pID}, NULL, {salary})";
            else if (role == "Coach")
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID, WeeklySalary) VALUES ({contractID}, '{terms}', NULL, {pID}, {salary})";

            if (query != "")
            {
                try
                {
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show("Contract Signed Successfully!");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label20.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Athlete").ToString();
                label22.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Team").ToString();
                label23.Text = dbManager.ExecuteScalar("SELECT ISNULL(MAX(Capacity),0) FROM Stadium").ToString();
                label24.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM InjuryRecord").ToString();
                label25.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Contract").ToString();
                label26.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Match").ToString();
                label27.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM League").ToString();

                RefreshUserList();

                MessageBox.Show("Dashboard and User List Updated!");
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            if (comboBox4.Text == "League Standings") query = "SELECT * FROM Team_Standings";
            else if (comboBox4.Text == "All Coaches") query = "SELECT CoachName, LicenseLevel FROM Coach";
            else if (comboBox4.Text == "Injury Log") query = "SELECT AthleteID, Details, Status FROM InjuryRecord";

            if (query != "")
            {
                DataTable dt = dbManager.ExecuteReader(query);
                dataGridView3.DataSource = dt;
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
    }
}