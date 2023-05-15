using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using IndividualProject.Business;
using System.Data.SqlClient;

namespace IndividualProject.Presentation
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void prenume_Click(object sender, EventArgs e)
        {
          

            
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string s1 = "select ang.prenume from angajati ang join users us on ang.id_angajat=us.id_angajat where us.Email='" + login_info.email + "';";
            MySqlConnection conn1 = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlCommand cmd1 = new MySqlCommand(s1, conn1);
            conn1.Open();
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                prenume.Text = reader1.GetValue(0).ToString();
            }
            conn1.Close();

            string s2 = "select ang.nume from angajati ang join users us on ang.id_angajat=us.id_angajat where us.Email='" + login_info.email + "';";

            MySqlConnection conn2 = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlCommand cmd2 = new MySqlCommand(s2, conn2);
            conn2.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                nume.Text = reader2.GetValue(0).ToString();
            }
            conn2.Close();
            string s3 = "select ang.telefon from angajati ang join users us on ang.id_angajat=us.id_angajat where us.Email='" + login_info.email + "';";
            MySqlConnection conn3 = new MySqlConnection("server=localhost;port=3306; database=mds;uid=root;password=123456;");
            MySqlCommand cmd3 = new MySqlCommand(s3, conn3);
            conn3.Open();
            MySqlDataReader reader3 = cmd3.ExecuteReader();

            while (reader3.Read())
            {
                telefon.Text = reader3.GetValue(0).ToString();
            }
            conn3.Close();
        }
    }
}
