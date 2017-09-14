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
      conf.Value.ServerName = "(LocalDb)\\MSSQLLocalDB";
      operationManager = new InsertOperations(conf);
      values = new OperationValues() { FirstValue = "11", OperationName="sum",SecondValue="55"};
	  


    }

    [TestMethod]
    public void TestInsertOperation()
    {
      var result = operationManager.Manage(values);

      Assert.IsTrue(result);

    }
  }
}
