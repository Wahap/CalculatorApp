using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Calculator.UserManager.Interfaces;
using Calculator.UserManager.BO;
using Calculator.UserManager.DTO;

namespace Calculator.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private IUserManager<List<User>, User> userManager;
        private LoadAllUsers loadAllUsers;

        public UserController():this(new LoadAllUsers())
        {

        }

        public UserController(IUserManager<List<User>, User> userManager)
        {
            this.userManager = userManager;
        }

        public UserController(LoadAllUsers loadAllUsers)
        {
            this.loadAllUsers = loadAllUsers;
        }
    }
}