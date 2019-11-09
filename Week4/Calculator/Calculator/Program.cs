using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string yesNo;
            do
            {
                // Ask user for first number.
                double userNum1;
                do
                {
                    Console.WriteLine("Enter first number: ");
                }
                while (!double.TryParse(Console.ReadLine(), out  userNum1));

                // Ask user for second number.
                double userNum2;
                do
                {
                    Console.WriteLine("Enter second number: ");
                }
                while (!double.TryParse(Console.ReadLine(), out userNum2));

                // Ask user for operator
                string[] allowedOperators = new string[5];
                allowedOperators[0] = "+";
                allowedOperators[1] = "-";
                allowedOperators[2] = "/";
                allowedOperators[3] = "*";
                allowedOperators[4] = "%";
                string userOperator;
                do
                {
                    Console.WriteLine("Input operator [+, -, /, *, %]: ");
                    userOperator = Console.ReadLine();
                }
                while (!allowedOperators.Contains(userOperator));

                switch (userOperator)
                {
                    case "+":
                        Console.WriteLine("{0} {2} {1} = {3}", userNum1, userNum2, userOperator, userNum1 + userNum2);
                        break;

                    case "-":
                        Console.WriteLine("{0} {2} {1} = {3}", userNum1, userNum2, userOperator, userNum1 - userNum2);
                        break;

                    case "/":
                        Console.WriteLine("{0} {2} {1} = {3}", userNum1, userNum2, userOperator, userNum1 / userNum2);
                        break;

                    case "*":
                        Console.WriteLine("{0} {2} {1} = {3}", userNum1, userNum2, userOperator, userNum1 * userNum2);
                        break;

                    case "%":
                        Console.WriteLine("{0} {2} {1} = {3}", userNum1, userNum2, userOperator, userNum1 % userNum2);
                        break;

                    default:
                        break;
                }

                Console.Write("Do you want another go (y/n): ");
                yesNo = Console.ReadLine();
            }
            while (yesNo == "y");
        }
    }
}
