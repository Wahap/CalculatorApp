
using Calculator.CommonSettings;
using Calculator.Data.Repos.DataContext;
using Calculator.Data.Repos.Interfaces;
using Calculator.Data.Repos.Model;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repos.BO
{
  public class UnitOfWorkForCalculatorDb : IUnitOfWorkForCalculatorDb
  {
    private CalculatorDb _calculatorDb;
    private IRepository<User> _user;
    private IRepository<Company> _company;
    private IRepository<OperationValues> _operation;
    private IOptions<Configurations> conf;
    public UnitOfWorkForCalculatorDb(IConnectionValue connectionValue,IOptions<Configurations> conf)
    {
      _calculatorDb = new CalculatorDb(conf);
    }

    public IRepository<User> UserRepository
    {
      get { return _user ?? (_user = new Repository<User>(_calculatorDb)); }
    }

    public IRepository<Company> CompanyReposiroty
    {
      get { return _company ?? (_company = new Repository<Company>(_calculatorDb)); }
    }

    public IRepository<OperationValues> OperationsRepository
    {
      get { return _operation ?? (_operation = new Repository<OperationValues>(_calculatorDb)); }
    }

   

    public void Dispose()
    {
      if (_calculatorDb == null) return;
      _calculatorDb.Dispose();
      _calculatorDb = null;
    }
  }
}
