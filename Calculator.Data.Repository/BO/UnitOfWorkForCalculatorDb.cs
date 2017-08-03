using Calculator.Data.Repository.Data;
using Calculator.Data.Repository.DataContext;
using Calculator.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repository.BO
{
    public class UnitOfWorkForCalculatorDb : IUnitOfWorkForCalculatorDb
    {
        private CalculatorDb _calculatorDb;
        private IRepository<User> _user;
        private IRepository<Company> _company;
        public UnitOfWorkForCalculatorDb(IConnectionValue connectionValue)
        {
            _calculatorDb = new CalculatorDb(connectionValue);
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
