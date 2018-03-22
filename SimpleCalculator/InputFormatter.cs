﻿using System;

namespace SimpleCalculator
{
    public class InputFormatter
    {
        public static double FormatNumber(string input)
        {
            double retVal;
            if (!double.TryParse(input, out retVal))
            {
                throw new ArgumentException("Input was not a number");
            }
            return retVal;
        }

        public static string FormatOperator(string op)
        {            
            double num;            

            if ((double.TryParse(op, out num) || !(op.ToLower().Equals("add") || op.ToLower().Equals("subtract") || op.ToLower().Equals("multiply") || op.ToLower().Equals("divide"))))
            {
                throw new NotSupportedException("Specified operation is not supported.");
            }
            return op;
        }
    }
}
