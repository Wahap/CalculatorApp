using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.UserManager.Interfaces;
using Calculator.UserManager.DTO;
using System.Collections.Generic;
using Calculator.UserManager.BO;

namespace Calculator.UserManager.Test
{
    [TestClass]
    public class LoadAllUserTest
    {
        private  IUserManager<List<User>, User> userManager;
        private User user;
        [TestInitialize]
        public void Init()
        {
            userManager = new LoadAllUsers();
            user = new User();
        }

        [TestMethod]
        public void TestLoadAllUser()
        {
         var users=   userManager.Manage(user); 

            Assert.IsTrue(users.Count > 0);

        }
    }
}
