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
        Login Login = new Login();
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
            
            int TotalRows = Login.NumberOfUsersWithSpecificName(email);
            if (TotalRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void AddUsersFromList(List<User> users)
        {
            this.users = users;
        }
        public bool UserNameCheck(string email)
        {
            int TotalRows = Login.NumberOfUsersWithSpecificName(email);
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
