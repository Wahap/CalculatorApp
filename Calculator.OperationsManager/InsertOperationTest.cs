using Calculator.CommonSettings;
using Calculator.Data.Repos.Model;
using Calculator.OperationsManager.BO;
using Calculator.OperationsManager.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.OperationsManager.Test
{


  [TestClass]
  public class InsertOperationTest
  {
    private IOptions<Configurations> conf;
    private IOperationDb<bool, OperationValues> operationManager;
    private OperationValues values;
   
    [TestInitialize]
    public void Init()
    {
      conf = Options.Create<Configurations>(new Configurations());
      conf.Value.CalculatorDbName = "calculatorDb";
      conf.Value.ServerName = "calculator.database.windows.net";
      conf.Value.UserName = "abdul";
      conf.Value.Password = "aa1011DD";
      operationManager = new InsertOperations(conf);
      values = new OperationValues() { FirstValue = "01", OperationName="div",SecondValue="20"};
	  


    }

    [TestMethod]
    public void TestInsertOperation()
    {
      var result = operationManager.Manage(values);

      Assert.IsTrue(result);

    }
  }
}
