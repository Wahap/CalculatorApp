using Calculator.Operations.Interfaces;

namespace Calculator.OperationsManager.BO
{
    public class DivideOperation<T> : IOperations<T, T, T>
    {
        public T Manage(T num1, T num2)
        {
            dynamic firstNumber = num1;
            dynamic secondNumber = num2;

            if (secondNumber==0 || null)
            {
                return (dynamic)0;
            }
            return firstNumber / secondNumber;
        }
    }

}
