using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sport_stat_hub
{
    public partial class Form2 : Form
    {
        // 1. The Bridge Address
        private string myConnectionAddress = @"Data Source=DESKTOP-SJMB0TS;Initial Catalog=Sports_Hub;Integrated Security=True;TrustServerCertificate=True";

        // 2. The Kitchen Manager
        private DBManager dbManager;

        public Form2()
        {
            InitializeComponent();
            //dbManager = new DBManager(myConnectionAddress);
        }

        // ==========================================
        // TAB 1: USER MANAGEMENT (REGISTER PEOPLE)
        // ==========================================
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Getting data using YOUR specific names
            string fullName = textBox1.Text;    // This is Full Name
            string password = textBox2.Text;    // This is Password
            string userType = comboBox1.Text;   // This is the Dropdown choice

            // 2. Generating a random ID (since your SQL script needs one)
            Random rnd = new Random();
            int newID = rnd.Next(100, 1000);

            string query = "";

            // 3. Routing the data to the correct SQL table
            if (userType == "Athlete")
            {
                query = $"INSERT INTO Athlete (AthleteID, AthleteName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            }
            else if (userType == "Coach")
            {
                query = $"INSERT INTO Coach (CoachID, CoachName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            }
            else if (userType == "MedicalStaff")
            {
                query = $"INSERT INTO MedicalStaff (StaffID, StaffName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            }
            else if (userType == "Admin")
            {
                query = $"INSERT INTO Admin (AdminID, AdminName, [Password]) VALUES ({newID}, '{fullName}', '{password}')";
            }

            // 4. Executing the SQL
            if (query != "")
            {
                try
                {
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show($"Success! {userType} registered.\nID: {newID}");

                    // Clear your boxes
                    textBox1.Clear();
                    textBox2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a role from the dropdown!");
            }
        }

        // ==========================================
        // TAB 2: STRUCTURE (LEAGUES & TEAMS)
        // ==========================================
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10, 1000); // Generates a random ID for the League

            // textBox5=Name, textBox6=Country, textBox7=Division
            string query = $"INSERT INTO League (LeagueID, LeagueName, Country, Division) " +
                           $"VALUES ({id}, '{textBox5.Text}', '{textBox6.Text}', '{textBox7.Text}')";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"League '{textBox5.Text}' created successfully!");
                textBox5.Clear(); textBox6.Clear(); textBox7.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10, 1000);

            // textBox8=Name, textBox9=City, comboBox2=LeagueID
            // For now, we assume you type a number in the ComboBox or we use 1 as a default
            string query = $"INSERT INTO Team (TeamID, TeamName, City, LeagueID) " +
                           $"VALUES ({id}, '{textBox8.Text}', '{textBox9.Text}', 1)";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show($"Team '{textBox8.Text}' registered in {textBox9.Text}!");
                textBox8.Clear(); textBox9.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10, 1000);

            // textBox10=Venue Name, textBox11=Capacity (Saving Capacity into 'Location' for now)
            string query = $"INSERT INTO Stadium (StadiumID, StadiumName, Location) " +
                           $"VALUES ({id}, '{textBox10.Text}', '{textBox11.Text}')";

            try
            {
                dbManager.ExecuteNonQuery(query);
                MessageBox.Show("Stadium added successfully!");
                textBox10.Clear(); textBox11.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ==========================================
        // TAB 3: CONTRACTS (FINANCE)
        // ==========================================
        private void button5_Click(object sender, EventArgs e)
        {
            // 1. Getting the data from YOUR names
            string role = comboBox3.Text;       // "Athlete" or "Coach"
            string pID = textBox3.Text;        // The ID of the person
            string salary = numericUpDown1.Value.ToString();
            string buyout = textBox12.Text;

            // We combine the dates and money into a "Terms" description
            string start = dateTimePicker1.Value.ToShortDateString();
            string end = dateTimePicker2.Value.ToShortDateString();
            string terms = $"Salary: ${salary}/week. Dates: {start} to {end}. Buyout: ${buyout}";

            // 2. Generate a random Contract ID
            Random rnd = new Random();
            int contractID = rnd.Next(1000, 9999);

            string query = "";

            // 3. Logic: If it's an Athlete, we put their ID in AthleteID. If Coach, in CoachID.
            if (role == "Athlete")
            {
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID) " +
                        $"VALUES ({contractID}, '{terms}', {pID}, NULL)";
            }
            else if (role == "Coach")
            {
                query = $"INSERT INTO Contract (ContractID, Terms, AthleteID, CoachID) " +
                        $"VALUES ({contractID}, '{terms}', NULL, {pID})";
            }

            // 4. Send to SQL
            if (query != "")
            {
                try
                {
                    dbManager.ExecuteNonQuery(query);
                    MessageBox.Show($"Contract Signed Successfully!\nRole: {role}\nContract ID: {contractID}");

                    // Clear the boxes
                    textBox3.Clear();
                    textBox12.Clear();
                    numericUpDown1.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Make sure the Athlete/Coach ID exists in SQL.\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select Athlete or Coach from the dropdown!");
            }
        }

        // ==========================================
        // TAB 4: REPORTS (STATS & STANDINGS)
        // ==========================================

        // This button updates the "Big Numbers" on your dashboard
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label20.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Athlete").ToString();
                label21.Text = "$" + dbManager.ExecuteScalar("SELECT ISNULL(AVG(TotalGoals),0) FROM Team").ToString(); // Example stat
                label22.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Team").ToString();
                label23.Text = dbManager.ExecuteScalar("SELECT MAX(Capacity) FROM Stadium").ToString();
                label24.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM InjuryRecord").ToString();
                label25.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Contract").ToString();
                label26.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM Match").ToString();
                label27.Text = dbManager.ExecuteScalar("SELECT COUNT(*) FROM League").ToString();

                MessageBox.Show("Dashboard Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // We try a very simple query just to say "Hello" to SQL
                //dbManager.ExecuteScalar("SELECT 1");
                //this.Text = "Admin Form - [CONNECTED TO SQL]"; // Changes the window title
            }
            catch (Exception ex)
            {
                //MessageBox.Show("CONNECTION FAILED!\nCheck your Server Name.\nError: " + ex.Message);
                //this.Text = "Admin Form - [CONNECTION FAILED]";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";
            if (comboBox4.Text == "League Standings")
                query = "SELECT * FROM Team_Standings";
            else if (comboBox4.Text == "All Coaches")
                query = "SELECT CoachName, LicenseLevel FROM Coach";
            else if (comboBox4.Text == "Injury Log")
                query = "SELECT AthleteID, Details, Status FROM InjuryRecord";

            if (query != "")
            {
                // Filling dataGridView3
                DataTable dt = dbManager.ExecuteReader(query);
                dataGridView3.DataSource = dt;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report exported to PDF (Simulated for Demo).");
        }
    }
}