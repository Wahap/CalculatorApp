using MongoDB.Driver;

namespace Calculator.MongoDb.Repos.Interfaces
{
  public interface IMongoDbRepository<T1>
  {
    IMongoCollection<T1> MongoCollection { get; }
  }
}
