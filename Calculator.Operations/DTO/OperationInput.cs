using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations.DTO
{
    public interface OperationInput<T>
    {
         T Num1 { get; set; }
         T Num2 { get; set; }
    }
}
