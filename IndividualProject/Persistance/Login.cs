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
        public List<User> GetUsers()
        {
            List<User> Users = new List<User>();
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("select * from users;", conn);
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
            MySqlConnection con = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("Select count(*) from users where Email= @alias", con);
            cmd.Parameters.AddWithValue("@alias", email);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return TotalRows;
        }
        public void CreateAccount(string email, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("insert into users(Email, Password)values('" + email + "','" + password + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void ResetPassword(string email, string password)
        {
            MySqlConnection conn = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("UPDATE `dbi477923`.`users`SET`Password` = '" + password + "' WHERE `Email` = '" + email + "'; ", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
