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

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "%");
        }
    }
}
