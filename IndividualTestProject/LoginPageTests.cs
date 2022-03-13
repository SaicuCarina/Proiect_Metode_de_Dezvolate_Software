using IndividualProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IndividualTestProject
{
    [TestClass]
    public class LoginPageTests
    {
        Administration administration = new Administration();
        [TestMethod]
        public void TestMethod1()
        {
            User user = new User(1,"asd@gmail.com","123");
            administration.AddUsers = user;
            user = new User(2, "dsa@gmail.com", "456");
            administration.AddUsers = user;
            List<User> Users = new List<User>();
            Users = administration.Users;
            CollectionAssert.AreEquivalent(Users,administration.Users);
            string message = administration.ReturnInfo(0);
            Assert.AreEqual($"asd@gmail.com has id: 1 and password: 123",message);
        }
        [TestMethod]
        public void IsValidMailTest()
        {
            string email1 = "asd@gmail.com";
            string email2 = "dsagkdj";
            string email3 = "";
            Assert.IsFalse(!administration.IsValidEmail(email1));
            Assert.IsFalse(administration.IsValidEmail(email2));
            Assert.IsFalse(administration.IsValidEmail(email3));
        }
    }
}
