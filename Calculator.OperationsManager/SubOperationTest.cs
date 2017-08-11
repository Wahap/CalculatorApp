using Calculator.Operations.BO;
using Calculator.Operations.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.OperationsManager.Test
{

    [TestClass]
    public class SubOperationTest
    {
        private IOperations<double, double, double> operationManager;
        private double number1;
        private double number2;
        [TestInitialize]
        public void Init()
        {
            operationManager = new SubOperation<double>();
            number1 = 3.2;
            number2 = 2.1;
        }

        [TestMethod]
        public void TestSubOperation()
        {
            var result = operationManager.Manage(number1, number2);

            Assert.IsTrue(result == 1.1);

        }
    }
}
