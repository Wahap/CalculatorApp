using Calculator.Data.Repository.Data;
using Calculator.Data.Repository.Interfaces;
using System.Configuration;

namespace Calculator.Data.Repository.DataContext
{
    public class ConnectionManager : IConnectionManager<IConnectionValue>
    {
        public ConnectionConfig conConfig { get; }
        public string GetCalculatorConnectionString(IConnectionValue value)
        {
            var settings = new ConnectionConfig();
            var dnName = value?.ServerName ?? conConfig.DefaultCalculatorDatabase;
            var serverName = value?.ServerName ?? conConfig.ServerName;

            var connectionString = "data source=" + serverName + ";Integrated Security=SSPI;" +
                                   "User Instance=false;" +
                                   "Initial Catalog=" + dnName;



            //var connectionString = "data source= (LocalDb)\\MSSQLLocalDB; Integrated Security=SSPI;" +
            //                       "User Instance=false;" +
            //                       "Initial Catalog=CalculatorDb";

            return connectionString;
        }
}
}
