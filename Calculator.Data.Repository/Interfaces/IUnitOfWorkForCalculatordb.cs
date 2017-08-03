using Calculator.Data.Repository.Data;
using System;

namespace Calculator.Data.Repository.Interfaces
{

    public interface IUnitOfWorkForCalculatorDb : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Company> CompanyReposiroty { get; }

    }
}
