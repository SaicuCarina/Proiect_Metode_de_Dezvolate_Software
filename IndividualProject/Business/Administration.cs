using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Administration
    {
        List<User> users = new List<User>();
        public User AddUsers
        {
            set { users.Add(value); }
        }
        public List<User> Users
        {
            get { return users; }
        }
        public string ReturnInfo(int i)
        {
            return $"{users[i].Email} has id: {users[i]} and password: {users[i].Password}";
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
        public bool IsInDatabase(string email)
        {
            MySqlConnection con = new MySqlConnection("server=studmysql01.fhict.local;database=dbi477923;uid=dbi477923;password=secret;");
            MySqlCommand cmd = new MySqlCommand("Select count(*) from users where Email= @alias", con);
            cmd.Parameters.AddWithValue("@alias", email);
            con.Open();
            int TotalRows = 0;
            TotalRows = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (TotalRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
