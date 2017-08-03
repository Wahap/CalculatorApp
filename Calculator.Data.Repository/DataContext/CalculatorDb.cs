using Calculator.Data.Repository.Data;
using Calculator.Data.Repository.Interfaces;
using System.Data.Entity;

namespace Calculator.Data.Repository.DataContext
{
    public class CalculatorDb : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Company> company { get; set; }


        public CalculatorDb(IConnectionValue connectionValue)
        {
            Database.Connection.ConnectionString = new ConnectionManager().GetCalculatorConnectionString(connectionValue);
            Database.SetInitializer<CalculatorDb>(null);
        }

    }
}
