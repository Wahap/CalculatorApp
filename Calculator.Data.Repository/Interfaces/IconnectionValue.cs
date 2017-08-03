using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repository.Interfaces
{
    public interface IConnectionValue
    {
        string CalculatorDbName { get; set; }
        //string ProjectDbName { get; set; }
        //string MetricsDbName { get; set; }

        string ServerName { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
