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




namespace IndividualProject.Presentation
{

    public partial class Community : UserControl
    {
        public Community()
        {
            InitializeComponent();
        }

        private void Community_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_locations_Click(object sender, EventArgs e)
        {
            DataSet result = new DataSet();
            string s = "select * from destinatii";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
            conn.Open();
            cmd.Fill(result, "destinatii");
            conn.Close();
            dgvTable.DataSource = result;
            dgvTable.DataMember = "destinatii";
        }

        private void btn_loc_chs_Click(object sender, EventArgs e)
        {
            string view = loc.Text;

            if (cb.SelectedItem == "cazari")
            {
                DataSet result = new DataSet();
                string s = "select * from cazari caz join destinatii des on caz.id_destinatie=des.id_destinatie where des.tara like '" + view + "';";
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
                MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
                conn.Open();
                cmd.Fill(result, "cazari");
                conn.Close();
                dgvTable.DataSource = result;
                dgvTable.DataMember = "cazari";
            }
            if (cb.SelectedItem == "obiective")
            {
                DataSet result = new DataSet();
                string s = "select * from obiective caz join destinatii des on caz.id_destinatie=des.id_destinatie where des.tara like '" + view + "';";
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
                MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
                conn.Open();
                cmd.Fill(result, "obiective");
                conn.Close();
                dgvTable.DataSource = result;
                dgvTable.DataMember = "obiective";
            }
            if (cb.SelectedItem == "transporturi")
            {
                DataSet result = new DataSet();
                string s = "select * from transporturi caz join destinatii des on caz.id_destinatie=des.id_destinatie where des.tara like '" + view + "';";
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
                MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
                conn.Open();
                cmd.Fill(result, "transporturi");
                conn.Close();
                dgvTable.DataSource = result;
                dgvTable.DataMember = "transporturi";
            }
            if (cb.SelectedItem == "oferte")
            {
                DataSet result = new DataSet();
                string s = "select * from oferte caz join destinatii des on caz.id_destinatie=des.id_destinatie where des.tara like '" + view + "';";
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
                MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
                conn.Open();
                cmd.Fill(result, "oferte");
                conn.Close();
                dgvTable.DataSource = result;
                dgvTable.DataMember = "oferte";
            }
        }

        private void btn_ph_Click(object sender, EventArgs e)
        {
            string ph = tb_ph.Text;

            DataSet result = new DataSet();
            string s = "select * from clienti where telefon like '" + ph + "';";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
            conn.Open();
            cmd.Fill(result, "clienti");
            conn.Close();
 
           
            dgvTable.DataSource = result;
            dgvTable.DataMember = "clienti";
          

        }


    }
}
