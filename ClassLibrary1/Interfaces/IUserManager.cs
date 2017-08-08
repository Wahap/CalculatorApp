using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.UserManager.Interfaces
{
    public interface IUserManager<T1,T2>
    {
        T1 Manage(T2 value);
    }
}
