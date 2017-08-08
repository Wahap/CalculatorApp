
using Calculator.Data.Repos.DataContext;
using Calculator.Data.Repos.Interfaces;
using Calculator.Data.Repos.Model;
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
        public UnitOfWorkForCalculatorDb(IConnectionValue connectionValue)
        {
            _calculatorDb = new CalculatorDb();
        }

        public IRepository<User> UserRepository
        {
            get { return _user ?? (_user = new Repository<User>(_calculatorDb)); }
        }

        public IRepository<Company> CompanyReposiroty
        {
            get { return _company ?? (_company = new Repository<Company>(_calculatorDb)); }
        }

     

        public void Dispose()
        {
            if (_calculatorDb == null) return;
            _calculatorDb.Dispose();
            _calculatorDb = null;
        }
    }
}
