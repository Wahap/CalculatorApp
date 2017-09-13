using Calculator.Data.Repos.Model;
using Calculator.MongoDb.Repos.BO;
using Calculator.MongoDb.Repos.Interfaces;
using Calculator.OperationsManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.OperationsManager.BO
{

  public class InsertOperationMongoDb : IOperationDb<bool, OperationValues>
  {
    private readonly IMongoDbManager<bool, OperationValues> mongoDbManager;

    public InsertOperationMongoDb() : this(new OperationValuesAdder())
    { }

    public InsertOperationMongoDb(IMongoDbManager<bool, OperationValues> mongoDbManager)
    {
      this.mongoDbManager = mongoDbManager;
    }
    public bool Manage(OperationValues user = null)
    {
      return mongoDbManager.Manage(user);
    }
  }
}
