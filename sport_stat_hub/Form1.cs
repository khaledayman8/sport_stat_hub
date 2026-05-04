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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            DataTable dt = controller.CheckLogin(textBox1.Text, textBox2.Text);

            if (dt == null || dt.Rows.Count == 0)
            {
                lblError.Text = "Invalid username or password!";
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;

                WelcomForm f = new WelcomForm(textBox1.Text);
                f.Show();
                this.Hide();
            }
        }
    }
}
