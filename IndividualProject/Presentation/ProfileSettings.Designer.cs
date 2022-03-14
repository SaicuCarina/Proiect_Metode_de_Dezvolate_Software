
namespace IndividualProject.Presentation
{
    partial class ProfileSettings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateDescription = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.tbModifyText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectWhatToModify = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 137);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateDescription
            // 
            this.btnUpdateDescription.Location = new System.Drawing.Point(16, 397);
            this.btnUpdateDescription.Name = "btnUpdateDescription";
            this.btnUpdateDescription.Size = new System.Drawing.Size(220, 33);
            this.btnUpdateDescription.TabIndex = 9;
            this.btnUpdateDescription.Text = "Update Profile Description";
            this.btnUpdateDescription.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(16, 242);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(550, 149);
            this.rtbDescription.TabIndex = 10;
            this.rtbDescription.Text = "";
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.Location = new System.Drawing.Point(16, 171);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(159, 33);
            this.btnUpdateImage.TabIndex = 11;
            this.btnUpdateImage.Text = "Update Image";
            this.btnUpdateImage.UseVisualStyleBackColor = true;
            // 
            // tbModifyText
            // 
            this.tbModifyText.Location = new System.Drawing.Point(293, 131);
            this.tbModifyText.Name = "tbModifyText";
            this.tbModifyText.Size = new System.Drawing.Size(198, 22);
            this.tbModifyText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select what you want to modify:";
            // 
            // cbSelectWhatToModify
            // 
            this.cbSelectWhatToModify.FormattingEnabled = true;
            this.cbSelectWhatToModify.Location = new System.Drawing.Point(293, 56);
            this.cbSelectWhatToModify.Name = "cbSelectWhatToModify";
            this.cbSelectWhatToModify.Size = new System.Drawing.Size(198, 24);
            this.cbSelectWhatToModify.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Insert text here:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectWhatToModify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModifyText);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.btnUpdateDescription);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProfileSettings";
            this.Size = new System.Drawing.Size(585, 454);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.TextBox tbModifyText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectWhatToModify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
