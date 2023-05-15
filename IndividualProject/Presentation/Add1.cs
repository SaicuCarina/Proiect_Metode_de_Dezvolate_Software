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
    public partial class Add1 : UserControl
    {
        public Add1()
        {
            InitializeComponent();
        }

        private void btn_add_c_Click(object sender, EventArgs e)
        {
            DataSet result = new DataSet();

            string first_name = tb_first.Text;
            string last_name = tb_last.Text;
            string phone = tb_ph.Text;
            string cnp = tb_cnp.Text;

            string s = "insert into clienti (nume, prenume, telefon, cnp) values ('" + last_name + "','" + first_name + "','" + phone + "','" + cnp + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
            conn.Open();
            cmd.Fill(result, "clienti");
            conn.Close();
            MessageBox.Show("Update complete!");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet result = new DataSet();

            string date = tb_date.Text;
            string id_client = tb_client.Text;
            string id_offer = tb_offer.Text;

            string s = "insert into primesc (data, id_client, id_oferta) values ('" + date + "','" + id_client + "','" + id_offer + "');";
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlDataAdapter cmd = new MySqlDataAdapter(s, conn);
            conn.Open();
            cmd.Fill(result, "primesc");
            conn.Close();
            MessageBox.Show("Update complete!");
        }
    }
}
