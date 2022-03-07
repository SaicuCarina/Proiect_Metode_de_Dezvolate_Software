
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
using MySql.Data.MySqlClient;

namespace IndividualProject
{
    public partial class CreateAccount : Form
    {
        Administration administration = new Administration();
        Login Login = new Login();
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbMail.Text != "")
            {
                if (administration.IsValidEmail(tbMail.Text) == true)
                {
                    if (tbPassword.Text != "")
                    {
                        if (tbPassword.Text == tbRepeatPassword.Text)
                        {
                            if (administration.UserNameCheck(tbMail.Text) == false)
                            {
                                Login.CreateAccount(tbMail.Text, tbPassword.Text);
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Closed += (s, args) => this.Close();
                                MessageBox.Show("Account created successfully!");
                                form1.Show();
                            }
                            else MessageBox.Show("Email already exists!");
                        }
                        else MessageBox.Show("Passwords don't match!");
                    }
                    else MessageBox.Show("Please fill in a password!");
                }
                else MessageBox.Show("Please fill in a valid email!");
            }
            else MessageBox.Show("Please fill in email!");
        }
        
    }
}
