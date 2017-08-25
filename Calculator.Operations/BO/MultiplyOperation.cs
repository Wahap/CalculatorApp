using Calculator.Operations.Interfaces;

namespace Calculator.OperationsManager.BO
{
    public class MultiplyOperation<T> : IOperations<T, T, T>
    {
        public T Manage(T num1, T num2)
        {
            dynamic firstNumber = num1;
            dynamic secondNumber = num2;

            return firstNumber * secondNumber;
        }
    }
}
