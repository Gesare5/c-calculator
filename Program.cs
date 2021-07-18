using System;
using System.Collections.Generic;

namespace MyCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string toContinue;
            Console.WriteLine("My Calculator");
            Console.WriteLine("Please pick +, -, x, / or sq for your operators.");
            Console.WriteLine();

            // create a list of type input class
            List<Input> previousCalculations = new List<Input>();

            // create a do-while loop that creates an instance of class input 
            // and adds it to the list
            // also allows a user to perform multiple operations

            do
            {
                Input firstInput = new Input();

                firstInput.GetInput();
                previousCalculations.Add(firstInput);
                System.Console.WriteLine();

                System.Console.Write("Do you wish to continue?[Y/N]: ");
                toContinue = Console.ReadLine();
                System.Console.WriteLine();

            } while (toContinue.ToLower() == "yes" || toContinue.ToLower() == "y");

            // to provide a user the option to view history of calculations

            System.Console.Write("View Calculation History?[Y/N]: ");
            string viewHistory = Console.ReadLine();
            System.Console.WriteLine();

            if (viewHistory.ToLower() == "y")
            {
                System.Console.WriteLine("CALCULATION HISTORY");

                // foreach loop to view items in the list
                foreach (var calculation in previousCalculations)
                {
                    Console.WriteLine("{0} {1} {2} = {3}", calculation.FirstNum, calculation.Operator,
                    calculation.SecondNum, calculation.Result);
                }

            }

        }

    }
}
