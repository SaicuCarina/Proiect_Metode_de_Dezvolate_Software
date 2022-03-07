﻿
namespace IndividualProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.cbKeepMeLoggedIn = new System.Windows.Forms.CheckBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(85, 117);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(134, 22);
            this.tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(85, 185);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(134, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(85, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 36);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(85, 340);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(134, 36);
            this.btnForgotPassword.TabIndex = 8;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // cbKeepMeLoggedIn
            // 
            this.cbKeepMeLoggedIn.AutoSize = true;
            this.cbKeepMeLoggedIn.Location = new System.Drawing.Point(85, 213);
            this.cbKeepMeLoggedIn.Name = "cbKeepMeLoggedIn";
            this.cbKeepMeLoggedIn.Size = new System.Drawing.Size(148, 21);
            this.cbKeepMeLoggedIn.TabIndex = 9;
            this.cbKeepMeLoggedIn.Text = "Keep me logged in";
            this.cbKeepMeLoggedIn.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(85, 298);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(134, 36);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 405);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.cbKeepMeLoggedIn);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.CheckBox cbKeepMeLoggedIn;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}

