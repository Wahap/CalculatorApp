
using Calculator.Data.Repos.Model;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Data.Repos.DataContext
{
  public class CalculatorDb : DbContext
  {
    public DbSet<User> user { get; set; }
    public DbSet<Company> company { get; set; }
    public DbSet<OperationValues> operationValues { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=CalculatorDb;Trusted_Connection=True;");
    }
  }
}
