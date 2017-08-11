using Calculator.Operations.DTO;
using Calculator.Operations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Operations.BO
{
    public class SumOperation<T> : IOperations<T, T, T>
    {
        public T Manage(T num1, T num2)
        {
            dynamic firstNumber = num1;
            dynamic secondNumber = num2;

            return firstNumber + secondNumber;
        }
    }
}
