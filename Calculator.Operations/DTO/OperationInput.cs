using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations.DTO
{
    public class OperationInput<T>
    {
        public T Num1 { get; set; }
        public T Num2 { get; set; }
    }
}
