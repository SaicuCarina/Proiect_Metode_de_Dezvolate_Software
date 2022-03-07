
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
                            if (UserNameCheck()==false)
                            {
                                MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
                                MySqlCommand cmd = new MySqlCommand("insert into users(Email, Password)values('" + tbMail.Text + "','" + tbPassword.Text + "')", conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                this.Hide();
                                Form1 form1 = new Form1();
                                form1.Closed += (s, args) => this.Close();
                                form1.Show();
                            }
                        }
                        else MessageBox.Show("Passwords don't match!");
                    }
                    else MessageBox.Show("Please fill in a password!");
                }
                else MessageBox.Show("Please fill in a valid email!");
            }
            else MessageBox.Show("Please fill in email!");
        }
        public bool UserNameCheck()
        {
            MySqlConnection con = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("Select count(*) from users where Email= @alias", con);
            cmd.Parameters.AddWithValue("@alias", tbMail.Text);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (TotalRows > 0)
            {
                MessageBox.Show("Email already exist");
                return true;
            }
            else
            {
                MessageBox.Show("Account created successfully!");
                return false;
            }
        }
    }
}
