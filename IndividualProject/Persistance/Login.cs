using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace IndividualProject
{

    public class Login
    {
        List<User> Users = new List<User>();
  

        public List<User> GetUsers()
        {
            List<User> Users = new List<User>();
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=mds;uid=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("select * from users", conn);
            conn.Open();
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                User user = new User(Convert.ToInt32(myReader[0]), myReader[1].ToString(), myReader[2].ToString());
                Users.Add(user);
            }
            conn.Close();
           
            return Users;
        }
        public int NumberOfUsersWithSpecificName(string email)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mds;uid=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("Select count(*) from users where Email= @alias", con);
            cmd.Parameters.AddWithValue("@alias", email);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return TotalRows;
        }
        public int NumberOfUsersWithSpecificID(string ID)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;port=3306;database=mds;uid=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("Select count(*) from angajati where id_angajat='" + ID + "'", con);
            cmd.Parameters.AddWithValue("@alias", ID);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return TotalRows;
        }
        public void CreateAccount(string email, string password, string id)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=mds;uid=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("insert into users(Email, Password, id_angajat)values('" + email + "','" + password + "','" + id + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void ResetPassword(string email, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;database=mds;uid=root;password=123456;");
            MySqlCommand cmd = new MySqlCommand("UPDATE `mds`.`users`SET`Password` = '" + password + "' WHERE `Email` = '" + email + "'; ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool IsValidEmail(string eMail)
        {
            bool Result = false;
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };
            return Result;
        }

        public bool VerifyCredentials(string email, string password, List<User> Users)
        {

            bool ok = false;
            for (int i = 0; i < Users.Count() && ok == false; i++)
            {
                 if (email == Users[i].Email)
                    if (password == Users[i].Password) return true;
            }
            return false;

        }
    }
}
