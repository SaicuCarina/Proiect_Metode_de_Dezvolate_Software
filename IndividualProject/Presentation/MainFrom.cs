using IndividualProject.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }
        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();

            Profile profile = new Profile();
            panelChildForm.Controls.Add(profile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();

            Community community = new Community();
            panelChildForm.Controls.Add(community);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
