using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace IndividualProject
{
    public partial class ResetPassword : Form
    {
        Administration administration = new Administration();
        string email = SendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
                    if (tbPassword.Text != "")
                    {
                        if (tbPassword.Text == tbPasswordRepeat.Text)
                        {
                            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
                            MySqlCommand cmd = new MySqlCommand("UPDATE `dbi477923`.`users`SET`Password` = '"+tbPassword.Text+"' WHERE `Email` = '"+email+"'; ", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Password reset successfully!");
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Closed += (s, args) => this.Close();
                            form1.Show();
                        }
                        else MessageBox.Show("Passwords don't match!");
                    }
                    else MessageBox.Show("Please enter a password!");
        }
    }
}
