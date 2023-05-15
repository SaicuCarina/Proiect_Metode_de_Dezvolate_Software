
namespace IndividualProject.Presentation
{
    partial class Community
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ph = new System.Windows.Forms.Button();
            this.tb_ph = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.btn_loc_chs = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.btn_locations = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_ph);
            this.panel1.Controls.Add(this.tb_ph);
            this.panel1.Controls.Add(this.loc);
            this.panel1.Controls.Add(this.btn_loc_chs);
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.btn_locations);
            this.panel1.Controls.Add(this.dgvTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Location:";
            // 
            // btn_ph
            // 
            this.btn_ph.Location = new System.Drawing.Point(90, 472);
            this.btn_ph.Name = "btn_ph";
            this.btn_ph.Size = new System.Drawing.Size(134, 37);
            this.btn_ph.TabIndex = 7;
            this.btn_ph.Text = "View";
            this.btn_ph.UseVisualStyleBackColor = true;
            this.btn_ph.Click += new System.EventHandler(this.btn_ph_Click);
            // 
            // tb_ph
            // 
            this.tb_ph.Location = new System.Drawing.Point(90, 427);
            this.tb_ph.Name = "tb_ph";
            this.tb_ph.Size = new System.Drawing.Size(134, 26);
            this.tb_ph.TabIndex = 6;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(90, 187);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(134, 26);
            this.loc.TabIndex = 5;
            // 
            // btn_loc_chs
            // 
            this.btn_loc_chs.Location = new System.Drawing.Point(90, 284);
            this.btn_loc_chs.Name = "btn_loc_chs";
            this.btn_loc_chs.Size = new System.Drawing.Size(134, 38);
            this.btn_loc_chs.TabIndex = 4;
            this.btn_loc_chs.Text = "View";
            this.btn_loc_chs.UseVisualStyleBackColor = true;
            this.btn_loc_chs.Click += new System.EventHandler(this.btn_loc_chs_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "cazari",
            "obiective",
            "transporturi",
            "oferte"});
            this.cb.Location = new System.Drawing.Point(90, 236);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(134, 28);
            this.cb.TabIndex = 3;
            // 
            // btn_locations
            // 
            this.btn_locations.Location = new System.Drawing.Point(90, 62);
            this.btn_locations.Name = "btn_locations";
            this.btn_locations.Size = new System.Drawing.Size(134, 38);
            this.btn_locations.TabIndex = 1;
            this.btn_locations.Text = "Locations";
            this.btn_locations.UseVisualStyleBackColor = true;
            this.btn_locations.Click += new System.EventHandler(this.btn_locations_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(320, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 28;
            this.dgvTable.Size = new System.Drawing.Size(1170, 541);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Community
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Community";
            this.Size = new System.Drawing.Size(1493, 547);
            this.Load += new System.EventHandler(this.Community_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btn_ph;
        private System.Windows.Forms.TextBox tb_ph;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.Button btn_loc_chs;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button btn_locations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
