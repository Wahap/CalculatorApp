using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations.DTO
{
    public interface OperationOutput<T>
    {
         T Result { get; set; }
    }
}
