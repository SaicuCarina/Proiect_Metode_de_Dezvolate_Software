
namespace IndividualProject.Presentation
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prenume = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbProfileImage.Location = new System.Drawing.Point(28, 23);
            this.pbProfileImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(179, 171);
            this.pbProfileImage.TabIndex = 0;
            this.pbProfileImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone number:";
            // 
            // prenume
            // 
            this.prenume.AutoSize = true;
            this.prenume.Location = new System.Drawing.Point(387, 38);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(51, 20);
            this.prenume.TabIndex = 4;
            this.prenume.Text = "label4";
            this.prenume.Click += new System.EventHandler(this.prenume_Click);
            // 
            // nume
            // 
            this.nume.AutoSize = true;
            this.nume.Location = new System.Drawing.Point(387, 94);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(51, 20);
            this.nume.TabIndex = 5;
            this.nume.Text = "label5";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(388, 153);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(51, 20);
            this.telefon.TabIndex = 6;
            this.telefon.Text = "label6";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbProfileImage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(657, 566);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prenume;
        private System.Windows.Forms.Label nume;
        private System.Windows.Forms.Label telefon;
    }
}
