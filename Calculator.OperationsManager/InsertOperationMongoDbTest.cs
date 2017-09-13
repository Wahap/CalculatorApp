using Calculator.Data.Repos.Model;
using Calculator.OperationsManager.BO;
using Calculator.OperationsManager.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.OperationsManager.Test
{

  [TestClass]
  public class InsertOperationMongoDbTest
  {
    private IOperationDb<bool, OperationValues> operationManager;
    private OperationValues values;
    [TestInitialize]
    public void Init()
    {
      operationManager = new InsertOperationMongoDb();
      values = new OperationValues() { FirstValue = "1", OperationName = "sum", SecondValue = "5" };



    }

    [TestMethod]
    public void TestInsertOperationMongoDb()
    {
      var result = operationManager.Manage(values);

      Assert.IsTrue(result);

    }
  }
}
