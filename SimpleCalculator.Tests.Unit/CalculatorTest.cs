using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "+");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            double result = Calculator.Calculate(3, 2, "-");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "*");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            double result = Calculator.Calculate(4, 2, "/");
            Assert.AreEqual(2, result);
        }

        //Adding Test Methods to test newly added functionalities

        [TestMethod]
        public void AddTwoNumbersOperatorChange()
        {
            double result = Calculator.Calculate(10, 20, "addition");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersOperatorChange()
        {
            double result = Calculator.Calculate(30, 10, "subtract");
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWhenN1LessThanN2()
        {
            double result = Calculator.Calculate(10, 20, "-");
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWhenN1LessThanN2OperatorChange()
        {
            double result = Calculator.Calculate(10, 20, "subtract");
            Assert.AreEqual(10, result);
        }
        
        [TestMethod]
        public void MultiplyTwoNumbersOperatorChange()
        {
            double result = Calculator.Calculate(10, 20, "multiply");
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void DivideTwoNumbersOperatorChange()
        {
            double result = Calculator.Calculate(20, 10, "divide");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbersWhenN1LessThanN2()
        {
            double result = Calculator.Calculate(10, 20, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbersWhenN1LessThanN2OperatorChange()
        {
            double result = Calculator.Calculate(10, 20, "Divide");
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "%");
        }
    }
}
