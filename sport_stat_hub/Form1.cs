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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace sport_stat_hub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Visible = false;
            if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }
            comboBox1.Items.Add("Athlete");
            comboBox1.Items.Add("Coach");
            comboBox1.Items.Add("MedicalStaff");
            comboBox1.Items.Add("Admin");


            comboBox1.SelectedIndex = 0; // optional default
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            string role = comboBox1.SelectedItem.ToString();
            int id;
            string password = textBox2.Text;

            if (!int.TryParse(textBox1.Text, out id))
            {
                lblError.Text = "Invalid ID format!";
                lblError.Visible = true;
                return;
            }

            DataTable dt = null;

            if (role == "Athlete")
            {
                dt = controller.AthleteLogin(id, password);
            }
            else if (role == "Coach")
            {
                dt = controller.CoachLogin(id, password);
            }
            else if (role == "MedicalStaff")
            {
                dt = controller.MedicalLogin(id, password);
            }
            else if (role == "Admin")
            {
                dt = controller.AdminLogin(id, password);
            }
            else
            {
                lblError.Text = "Please select a role!";
                lblError.Visible = true;
                return;
            }

            if (dt != null && dt.Rows.Count > 0)
            {
                lblError.Visible = false;

                if (role == "Athlete")
                {
                    AthleteForm f = new AthleteForm(id);
                }
                else if (role == "Coach")
                {
                    CoachDashboard f = new CoachDashboard(id);
                }
                else if (role == "MedicalStaff")
                {
                    Medical_Dashboard f = new Medical_Dashboard(id);
                }
                else if (role == "Admin")
                {
                    Form2 adminForm = new Form2(); 
                    adminForm.Show();
                }

                this.Hide();
            }
            else
            {
                lblError.Text = "Invalid credentials!";
                lblError.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';  
            else
                textBox2.PasswordChar = '*';    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
