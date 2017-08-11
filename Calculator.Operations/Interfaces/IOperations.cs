using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations.Interfaces
{
    public interface IOperations<T1,T2, out T3>
    {
        T2 Manage(T1 num1,T2 num2);
    }
}
