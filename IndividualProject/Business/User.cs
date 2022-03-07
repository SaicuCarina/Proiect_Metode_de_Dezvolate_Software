using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class User
    {
        int id;
        string email, password;
        public User(int id, string username, string password)
        {
            this.id = id;
            this.email = username;
            this.password = password;
        }
        public int ID
            {
            get { return id; }
            set { id = value; }
            }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
