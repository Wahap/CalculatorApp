using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.UserManager.Interfaces;
using Calculator.UserManager.DTO;
using System.Collections.Generic;
using Calculator.UserManager.BO;
using Microsoft.Extensions.Options;
using Calculator.CommonSettings;

namespace Calculator.UserManager.Test
{
  [TestClass]
  public class LoadAllUserTest
  {
    private IUserManager<List<User>, User> userManager;
    private IOptions<Configurations> conf;
    private User user;
    [TestInitialize]
    public void Init()
    {

      conf= Options.Create<Configurations>(new Configurations());
      conf.Value.CalculatorDbName = "CalculatorDb";
      conf.Value.ServerName = "calculator.database.windows.net";
      conf.Value.UserName = "abdul";
      conf.Value.Password = "aa1011DD";
      userManager = new LoadAllUsers(conf);
      user = new User();
    }

    [TestMethod]
    public void TestLoadAllUser()
    {
      var users = userManager.Manage(user);

      Assert.IsTrue(users.Count > 0);

    }
  }
}
