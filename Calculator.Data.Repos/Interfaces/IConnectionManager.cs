using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data.Repos.Interfaces
{
    interface IConnectionManager<T>
    {
        string GetCalculatorConnectionString(T value);
    }
}
