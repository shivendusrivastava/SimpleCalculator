﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class InputFormatterTest
    {
        [TestMethod]
        public void ConvertStringToNumber()
        {
            string num = "1";
            double formattedNum = InputFormatter.FormatNumber(num);
            Assert.AreEqual(1, formattedNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailToConvertStringToNumber()
        {
            string num = "a";
            double formattedNum = InputFormatter.FormatNumber(num);
        }

        [TestMethod]
        public void ConfirmAddSymbolicOperationIsSupported()
        {
            string op = "+";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("+", formattedOp);
        }

        [TestMethod]
        public void ConfirmSubtractSymbolicOperationIsSupported()
        {
            string op = "-";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("-", formattedOp);
        }

        [TestMethod]
        public void ConfirmMultiplySymbolicOperationIsSupported()
        {
            string op = "*";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("*", formattedOp);
        }

        [TestMethod]
        public void ConfirmDivideSymbolicOperationIsSupported()
        {
            string op = "/";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("/", formattedOp);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Partially()
        {
            string op = "1";
            string formattedOp = InputFormatter.FormatOperator(op);
        }

        [TestMethod]
        
        public void ConfirmAddNamedOperation()
        {
            string op = "add";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("add", formattedOp);
        }

        [TestMethod]       
        public void ConfirmSubtractNamedOperation()
        {
            string op = "subtract";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("subtract", formattedOp);
        }

        [TestMethod]        
        public void ConfirmMultiplyNamedOperation()
        {
            string op = "multiply";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("multiply", formattedOp);
        }

        [TestMethod]        
        public void ConfirmDivideNamedOperation()
        {
            string op = "divide";
            string formattedOp = InputFormatter.FormatOperator(op);
            Assert.AreEqual("divide", formattedOp);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidOperatorsAreNotSupported_Partially()
        {
            string op = "modulo";
            string formattedOp = InputFormatter.FormatOperator(op);
        }
    }
}
