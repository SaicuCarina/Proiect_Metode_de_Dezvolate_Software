using IndividualProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.Business
{
    public class LoginAdministration
    {
        List<User> WebUsers = new List<User>();
        Login login = new Login();
        public bool VerifyCredentials(string email, string password)
        {
            for (int i = 0; i < WebUsers.Count(); i++)
            {
                if (email == WebUsers[i].Email)
                    if (password== WebUsers[i].Password) return true;
            }
            return false;
        }

        public bool VerifyLogin(string email, string password)
        {
            WebUsers = login.GetUsers();
            bool a = VerifyCredentials(email, password);

            return a;

        }


    }
}
