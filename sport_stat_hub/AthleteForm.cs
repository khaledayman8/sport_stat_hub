using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace sport_stat_hub
{
    public partial class AthleteForm : Form
    {
        Controller controllerObj;

        int athleteID;
        public AthleteForm(int id)
        {
            InitializeComponent();

            athleteID = id;

            controllerObj = new Controller();

            LoadAthleteData();

            label1.Text = "Name: " ;
            label2.Text = "Height: ";

            DataTable dt = controllerObj.GetFullAthleteStats(athleteID);
            dataGridView1.DataSource = dt;

            DataTable dt1 = controllerObj.GetPreviousMatches(athleteID);
            dataGridView2.DataSource = dt1;

            DataTable dt3 = controllerObj.GetAthleteTraining(athleteID);
            dataGridView3.DataSource = dt3;

            DataTable dt4 = controllerObj.GetAthleteInjuries(athleteID);
            dataGridView5.DataSource = dt4;
        }

        private void LoadAthleteData()
        {
            DataTable dt = controllerObj.GetAthleteProfile(athleteID);

            if (dt.Rows.Count > 0)
            {
                label4.Text = dt.Rows[0]["AthleteName"].ToString();

                label5.Text = dt.Rows[0]["Height"].ToString();

                label6.Text = dt.Rows[0]["Weight"].ToString();

                label13.Text = dt.Rows[0]["TeamName"].ToString();

                label14.Text = dt.Rows[0]["LeagueName"].ToString();

                label15.Text = dt.Rows[0]["TotalGoals"].ToString();

                label16.Text = dt.Rows[0]["TotalAssists"].ToString();

                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
            }
            else
            {
                MessageBox.Show("Athlete not found");
            }
        }

        private void AthleteForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int height;

            if (!int.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("Enter valid height");
                return;
            }

            int result = controllerObj.UpdateHeight(athleteID, height);

            if (result > 0)
            {
                MessageBox.Show("Height updated successfully");
                LoadAthleteData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int weight;

            if (!int.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("Enter valid weight");
                return;
            }

            int result = controllerObj.UpdateWeight(athleteID, weight);

            if (result > 0)
            {
                MessageBox.Show("Weight updated successfully");
                LoadAthleteData();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
