using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace IndividualProject
{
    public partial class SendCode : Form
    {
        Administration administration = new Administration();
        string randomCode;
        public static string to;
        public SendCode()
        {
            InitializeComponent();
        }
        private void SendCode_Load(object sender, EventArgs e)
        {

        }
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(100000,999999)).ToString();
            MailMessage message = new MailMessage();

            if (tbEmail.Text != "")
            {
                if (administration.IsValidEmail(tbEmail.Text) == true)
                {
                    if (administration.IsInDatabase(tbEmail.Text) == true)
                    {
                        to = tbEmail.Text.ToString();
                        from = "oodapplication@gmail.com";
                        pass = "Qwerty123!";
                        messageBody = "Your reset code is: " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Password reseting code";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryFormat = (SmtpDeliveryFormat)SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from,pass);
                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Code sent!");
                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else MessageBox.Show("Code sent!");
                }
                else MessageBox.Show("Please enter a valid email!");
            }
            else MessageBox.Show("Please enter email!");
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (tbCode.Text.ToString() == randomCode)
            {
                to = tbEmail.Text;
                ResetPassword resetPassword = new ResetPassword();
                this.Hide();
                resetPassword.Closed += (s, args) => this.Close();
                resetPassword.Show();

            }
            else MessageBox.Show("Invalid code!");
        }

        
    }
}
