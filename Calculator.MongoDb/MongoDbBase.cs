using Calculator.Services;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.MongoDb.Repos
{

  public class MongoDbBase
  {
    //  private static IOptions<Configurations> settings;
    public MongoDbBase()
    {
      //   this.settings = Configurations.;
    }
    private static IMongoDatabase operationMongo;

    public static IMongoDatabase OperationMongo = operationMongo ?? (operationMongo = new MongoClient("mongodb://localhost:27017/operationstest")
                                                   .GetDatabase("operationstest"));

  }
}
