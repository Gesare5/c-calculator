using System;

namespace MyCalculatorApp
{
    public class Operations
    {
        // Method for addition
        public double AddOperation(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method for subtraction
        public double SubOperation(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method for multiplication
        public double MultiplicationOperation(double num1, double num2)
        {
            return num1 * num2;
        }

        // Method for division
        public double DivisionOperation(double num1, double num2)
        {

            if (num2 == 0)
            {
                return 0;
            }
            return num1 / num2;

            // try
            // {
            //     return num1 / num2;
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Division of {0} by zero. Cannot be done.", num1);
            //      return 0;
            // }
            // 
        }

        public double SquareOperation(double num)
        {
            return num * num;
        }
    }
}
