using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Calculator.UserManager.Interfaces;
using Calculator.UserManager.BO;
using Calculator.UserManager.DTO;
using Microsoft.Extensions.Options;
using Calculator.CommonSettings;

namespace Calculator.Services.Controllers
{

  [Route("api/userCont")]
  public class UserController : Controller
  {

    private IUserManager<List<User>, User> userListManager;
    private IUserManager<User, User> userManager;
    private IOptions<Configurations> settings;

    public UserController(IUserManager<List<User>, User> userListManager, IUserManager<User, User> userManager, IOptions<Configurations> settings)
    {
      this.userListManager = userListManager;
      this.userManager = userManager;
      this.settings = settings;
    }



    [HttpPost]
    [Route("getusers")]
    public List<User> GetUsers([FromBody] User user = null)
    {
      return userListManager.Manage(user);
    }

    [HttpPost]
    [Route("login")]
    public User Login([FromBody] User user = null)
    {
      return userManager.Manage(user);
    }


  }
}