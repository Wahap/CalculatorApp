using Calculator.Data.Repos.Model;
using Calculator.MongoDb.Repos.Interfaces;
using MongoDB.Driver;


namespace Calculator.MongoDb.Repos.BO
{


  public abstract class OperationManager<T1, T2> : IMongoDbManager<T1, T2>, IMongoDbRepository<OperationValues> where T2 : class
  {

    protected OperationManager(IMongoDatabase mongoDatabase)
    {
      MongoCollection = mongoDatabase.GetCollection<OperationValues>("operations");
    }

    public IMongoCollection<OperationValues> MongoCollection { get; }
    public abstract T1 Manage(T2 value = null);
  }
}
