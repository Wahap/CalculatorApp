using AuthenticateUser.BO;
using AuthenticateUser.DTO;
using AuthenticateUser.Interfaces;

using NUnit.Framework;
using System.Collections.Generic;

namespace AuthenticateUser.Test
{
    [TestFixture]
    public class LoadAllUserTest
    {
        private IAuthenticateManager<List<User>, User> _loadVehicle;
        private User _user;

        [SetUp]
        public void Init()
        {
            _loadVehicle = new LoadAllUsers();
            _user = new User();
        }


        [Test]
        public void TestLoadAllUsers()
        {
            var users = _loadVehicle.Manage(_user);
            Assert.IsTrue(users.Count > 0);
        }
     

    }
}
