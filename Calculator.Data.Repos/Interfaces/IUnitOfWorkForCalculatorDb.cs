
using Calculator.Data.Repos.Model;
using System;

namespace Calculator.Data.Repos.Interfaces
{

  public interface IUnitOfWorkForCalculatorDb : IDisposable
  {
    IRepository<User> UserRepository { get; }
    IRepository<Company> CompanyReposiroty { get; }
    IRepository<OperationValues> OperationsRepository { get; }

  }
}
