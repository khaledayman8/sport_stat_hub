using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AthleteForm(string username)
        {
            InitializeComponent();
            label1.Text = "Name: " ;
            label2.Text = "Height: ";
            label3.Text = "Weight: ";

        }

        private void AthleteForm_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
