using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Calculator.UserManager.Interfaces;
using Calculator.UserManager.BO;
using Calculator.UserManager.DTO;

namespace Calculator.Services.Controllers
{

    [Route("api/userCont")]
    public class UserController : Controller
    {
  
        private IUserManager<List<User>, User> userListManager;
        private IUserManager<User, User> userManager;

        public UserController(IUserManager<List<User>, User> userListManager, IUserManager<User, User> userManager)
        {
            this.userListManager = userListManager;
            this.userManager = userManager;
        }



        [HttpPost]
        [Route("getusers")]
        public List<User> GetUsers([FromBody] User user=null)
        {
            return userListManager.Manage(user);
        }

        [HttpPost]
        [Route("getuser")]
        public User GetUser([FromBody] User user = null)
        {
            return userManager.Manage(user);
        }


    }
}