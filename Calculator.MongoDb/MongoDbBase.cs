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
    static string connectionString = @"mongodb://calculator:lw23N3goFtzboFvuoUu8kMdjzhRWokeL3c0PYlHZSWyCmLKIO7EWg7gPXh4AEOvI9YmFv9UdJOlC3ovbsvqFew==@calculator.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";

    public static IMongoDatabase OperationMongo = operationMongo ?? (operationMongo = new MongoClient(connectionString)
                                                   .GetDatabase("operationstest"));

  }
}
