using Calculator.Operations.Interfaces;
using Calculator.OperationsManager.BO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.OperationsManager
{


    [TestClass]
    public class SumOperationTest
    {
        private IOperations<dynamic, dynamic, dynamic> operationManager;
        private dynamic number1;
        private dynamic number2;
        [TestInitialize]
        public void Init()
        {
            operationManager = new SumOperation<dynamic>();
            number1 = 2.5;
            number2 = 3;
        }

        [TestMethod]
        public void TestSumOperation()
        {
            var result = operationManager.Manage(number1, number2);

            Assert.IsTrue(result==5.5);

        }
    }
}
