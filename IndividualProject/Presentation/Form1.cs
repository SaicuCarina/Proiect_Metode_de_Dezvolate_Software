﻿
using IndividualProject.Business;
using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        Administration Administration = new Administration();
        Login Login = new Login();
        List<User> Users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Email!=string.Empty)
            {
                tbEmail.Text = Properties.Settings.Default.Email;
                tbPassword.Text = Properties.Settings.Default.Password;
                cbKeepMeLoggedIn.Checked = true;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users = Login.GetUsers();

            if (tbEmail.Text != "" )
            {
                if (tbPassword.Text != "")
                {
                    if (Administration.IsValidEmail(tbEmail.Text) == true)
                    {
                        bool ok = Login.VerifyCredentials(tbEmail.Text,tbPassword.Text, Users);
                        if (ok == true)
                        {
                            if (cbKeepMeLoggedIn.Checked == true)
                            {
                                Properties.Settings.Default.Email = tbEmail.Text;
                                Properties.Settings.Default.Password = tbPassword.Text;
                                Properties.Settings.Default.Save();
                            }
                            else
                            {
                                Properties.Settings.Default.Email = "";
                                Properties.Settings.Default.Password = "";
                                Properties.Settings.Default.Save();
                            }
                            login_info.email = tbEmail.Text;
                            this.Hide();
                            MainFrom mainFrom = new MainFrom();
                            mainFrom.Closed += (s, args) => this.Close();
                            mainFrom.Show();
                        }
                        else MessageBox.Show("Login failed!");
                    }
                    else MessageBox.Show("Please insert a valid mail!");
                }
                else MessageBox.Show("Please fill in password!");
            }
            else MessageBox.Show("Please fill in username!");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createAccount = new CreateAccount();
            createAccount.Closed += (s, args) => this.Close();
            createAccount.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendCode sendcode = new SendCode();
            sendcode.Show();
        }
    }
}
