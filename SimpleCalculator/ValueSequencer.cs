using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ValueSequencer
    {
        public static void GetNumberOrder(ref double firstNumber, ref double secondNumber)
        {            
            if (firstNumber < secondNumber)
            {
                firstNumber = firstNumber + secondNumber;
                secondNumber = firstNumber - secondNumber;
                firstNumber = firstNumber - secondNumber;
            }
        }
    }
}
