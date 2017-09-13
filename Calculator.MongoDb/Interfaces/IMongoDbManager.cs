namespace Calculator.MongoDb.Repos.Interfaces
{
  public interface IMongoDbManager<out T1, in T2> where T2 : class
  {
    T1 Manage(T2 value = null);
  }
}
