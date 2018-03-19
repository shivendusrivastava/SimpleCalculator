using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static double Calculate(double firstNum, double secondNum, string op)
        {
            double result;
            switch (op)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }
}
