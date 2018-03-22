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
                case "add":
                    result = firstNum + secondNum;
                    break;
                case "-":
                case "subtract":
                    result = firstNum - secondNum;
                    break;
                case "*":
                case "multiply":
                    result = firstNum * secondNum;
                    break;
                case "/":
                case "divide":
                    result = firstNum / secondNum;
                    break;
                default:
                    throw new NotSupportedException("Specified operation is not supported");
            }
            return result;
        }
    }
}
