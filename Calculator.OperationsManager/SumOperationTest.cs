using Calculator.Operations.BO;
using Calculator.Operations.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.OperationsManager
{


    [TestClass]
    public class SumOperationTest
    {
        private IOperations<int, int, int> operationManager;
        private int number1;
        private int number2;
        [TestInitialize]
        public void Init()
        {
            operationManager = new SumOperation<int>();
            number1 = 2;
            number2 = 3;
        }

        [TestMethod]
        public void TestSumOperation()
        {
            var result = operationManager.Manage(number1, number2);

            Assert.IsTrue(result==5);

        }
    }
}
