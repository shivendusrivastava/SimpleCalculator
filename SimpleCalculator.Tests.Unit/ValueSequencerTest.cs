using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class ValueSequencerTest
    {
        [TestMethod]
        public void SwapNumbersWhenN1LessThanN2()
        {
            double num1 = 10, num2 = 20;
            ValueSequencer.GetNumberOrder(ref num1, ref num2);
            Assert.AreEqual(num1>num2, true);
        }

        [TestMethod]
        public void DoNotSwapNumbers()
        {
            double num1 = 20, num2 = 10;
            ValueSequencer.GetNumberOrder(ref num1, ref num2);
            Assert.AreEqual(num1 > num2, true);
        }
   }
}
