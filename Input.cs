using System;

namespace MyCalculatorApp
{
    public class Input
    {

        public double FirstNum { get; set; }

        public double SecondNum { get; set; }

        public string Operator { get; set; }

        public double Result { get; set; }

        // for operations requiring two inputs
        public void TwoInputs()
        {
            Console.Write("Enter First Number: ");
            FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            SecondNum = Convert.ToDouble(Console.ReadLine());
        }

        // for operations requiring a single input
        public void OneInput()
        {
            Console.Write("Enter Number: ");
            FirstNum = Convert.ToDouble(Console.ReadLine());
        }

        // Main method; handles all the different types of operations
        public void GetInput()
        {

            Console.Write("Enter Operation: ");
            Operator = Console.ReadLine();

            Operations newOperator = new Operations();


            switch (Operator)
            {
                case "+":
                    {
                        // code block
                        TwoInputs();
                        Result = newOperator.AddOperation(FirstNum, SecondNum);
                        Console.WriteLine("Result is: {0} ", Result);
                        break;
                    }

                case "-":
                    {
                        // code block
                        TwoInputs();
                        Result = newOperator.SubOperation(FirstNum, SecondNum);
                        Console.WriteLine("Result is: {0} ", Result);
                        break;
                    }

                case "x":
                    {
                        // code block
                        TwoInputs();
                        Result = newOperator.MultiplicationOperation(FirstNum, SecondNum);
                        Console.WriteLine("Result is: {0} ", Result);
                        break;
                    }

                case "/":
                    {
                        // code block
                        TwoInputs();
                        Result = newOperator.DivisionOperation(FirstNum, SecondNum);
                        Console.WriteLine("Result is: {0} ", Result);
                        break;
                    }

                case "sq":
                    {
                        // code block
                        OneInput();
                        Result = newOperator.SquareOperation(FirstNum);
                        Console.WriteLine("Result is: {0} ", Result);
                        break;
                    }

                default:
                    // code block
                    Console.WriteLine("INVALID OPERATION!!!");
                    break;
            }

        }
    }
}