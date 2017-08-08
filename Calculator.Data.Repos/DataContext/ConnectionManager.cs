

using Calculator.Data.Repos.Interfaces;

namespace Calculator.Data.Repos.DataContext
{
    public class ConnectionManager : IConnectionManager<IConnectionValue>
    {
        
        public string GetCalculatorConnectionString(IConnectionValue value)
        {

            //var dnName =  value?.ServerName ?? ConfigurationManager.AppSettings["DefaultCalculatorDatabase"].ToLower();
            //var serverName = value?.ServerName ??  ConfigurationManager.AppSettings["ServerName"].ToLower(); ;

            ////var connectionString = "data source=" + serverName + ";Integrated Security=SSPI;" +
            ////                       "User Instance=false;" +
            //                       "Initial Catalog=" + dnName;



            var connectionString = "data source= (LocalDb)\\MSSQLLocalDB; Integrated Security=SSPI;" +
                                   "User Instance=false;" +
                                   "Initial Catalog=CalculatorDb";

            return connectionString;
        }
}
}
