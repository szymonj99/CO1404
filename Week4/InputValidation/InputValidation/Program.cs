using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you sure you want to delete this record? [y/n]");
            // Store the pressed key info.
            string userInput = Console.ReadLine().ToLower();
            // Get user's decision.
            while (userInput != "y" && userInput != "n")
            {
                Console.WriteLine("Sorry, you must answer 'y' or 'n'.");
                userInput = Console.ReadLine().ToLower();
            }

            if (userInput == "y")
            {
                Console.WriteLine("Record deleted.");
            }
            else
            {
                Console.WriteLine("Record NOT deleted.");
            }

            // Wait for user input and clear window.
            Console.ReadLine();
            Console.Clear();

            int minYear = 1900;
            int maxYear = 2011;
            Console.WriteLine("What is your year of birth? {0} to {1}", minYear, maxYear);
            bool isInt = false;
            isInt = int.TryParse(Console.ReadLine(), out int userYear);
            while (!isInt)
            {
                Console.WriteLine("Sorry, please enter a valid year.", minYear, maxYear);
                isInt = int.TryParse(Console.ReadLine(), out userYear);
            }

            Console.WriteLine("You are about {0} years old.", DateTime.Now.Year - userYear);
            Console.ReadLine();
        }
    }
}
