﻿
using Calculator.CommonSettings;
using Calculator.Data.Repos.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Calculator.Data.Repos.DataContext
{
  public class CalculatorDb : DbContext
  {
    public DbSet<User> user { get; set; }
    public DbSet<Company> company { get; set; }
    public DbSet<OperationValues> operationValues { get; set; }
    private IOptions<Configurations> conf;

    public CalculatorDb(IOptions<Configurations> conf)
    {
      this.conf = conf;
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      string connectionString = "Server=tcp:" + conf.Value.ServerName + ",1433;Initial Catalog=" + conf.Value.CalculatorDbName + ";Persist Security Info=False;User ID=" + conf.Value.UserName + ";Password=" + conf.Value.Password + ";MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

     // string connectionString = @"Server=" + conf.Value.ServerName + ";Database=" + conf.Value.CalculatorDbName + ";Trusted_Connection=True;";

      optionsBuilder.UseSqlServer(connectionString);
    }
  }
}
