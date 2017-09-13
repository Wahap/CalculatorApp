using Calculator.Data.Repos.Model;
using Calculator.OperationsManager.BO;
using Calculator.OperationsManager.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.OperationsManager.Test
{


  [TestClass]
  public class InsertOperationTest
  {
    private IOperationDb<bool, OperationValues> operationManager;
    private OperationValues values;
    [TestInitialize]
    public void Init()
    {
      operationManager = new InsertOperations();
      values = new OperationValues() { FirstValue = "1", OperationName="sum",SecondValue="5"};
	  


    }

    [TestMethod]
    public void TestInsertOperation()
    {
      var result = operationManager.Manage(values);

      Assert.IsTrue(result);

    }
  }
}
