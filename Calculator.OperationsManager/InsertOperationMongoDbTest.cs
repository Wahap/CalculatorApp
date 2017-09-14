using Calculator.CommonSettings;
using Calculator.Data.Repos.Model;
using Calculator.OperationsManager.BO;
using Calculator.OperationsManager.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.OperationsManager.Test
{

  [TestClass]
  public class InsertOperationMongoDbTest
  {
    private IOperationDb<bool, OperationValues> operationManager;
    private OperationValues values;
    private IOptions<Configurations> conf;
    [TestInitialize]
    public void Init()
    {
      conf = Options.Create<Configurations>(new Configurations());
      conf.Value.MongoDbServer = "mongodb://localhost:27017";
      conf.Value.MongoDbDatabase = "operationstest";
      operationManager = new InsertOperationMongoDb();
      values = new OperationValues() { FirstValue = "11", OperationName = "div", SecondValue = "12" };



    }

    [TestMethod]
    public void TestInsertOperationMongoDb()
    {
      var result = operationManager.Manage(values);

      Assert.IsTrue(result);

    }
  }
}
