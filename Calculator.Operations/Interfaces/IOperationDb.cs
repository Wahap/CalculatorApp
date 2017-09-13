using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.OperationsManager.Interfaces
{
    public interface IOperationDb<T1,T2>
    {
    T1 Manage(T2 value);
    }
}
