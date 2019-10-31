using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change exchange rate based on user input.
            double exchangeRate = ChangeExchangeRate(GetCurrencyInput());
            Console.WriteLine("The exchange rate is {0}", Math.Round(exchangeRate, 2, MidpointRounding.AwayFromZero));

            // Ask user to input the amount of money they want to convert.
            int currencyAmount = GetCurrencyAmount();

            // Print out currency after exchange rate.
            PrintConvertedAmount(currencyAmount, exchangeRate);

            // Ask user if they wish to convert more currency.
            if (GoAgain())
            {
                Console.Clear();
                Main(null);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user what currency they want to convert.
        /// </summary>
        /// <returns>int user input.</returns>
        static int GetCurrencyInput()
        {
            // Ask user for input.
            Console.WriteLine("Type 1 to convert from £ to $.");
            Console.WriteLine("Type 2 to convert from $ to £.");
            // while input is not int or does not fit criteria, ask again.
            bool isInt = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isInt || !(1 <= userInput && userInput <= 2))
            {
                Console.Clear();
                Console.WriteLine("Type 1 to convert from £ to $.");
                Console.WriteLine("Type 2 to convert from $ to £.");
                isInt = int.TryParse(Console.ReadLine(), out userInput);
            }
            Console.WriteLine("You chose {0}.", userInput);
            return userInput;
        }

        /// <summary>
        /// Get the exchange rate for operation based on user input.
        /// </summary>
        /// <param name="userInput">hat option has the user chosen.</param>
        /// <returns>double exchange rate.</returns>
        static double ChangeExchangeRate(int userInput)
        {
            // What is the exchange rate of £ to $?
            double exchangeRate = 1.5;
            // Return exchange rate based on input.
            if (userInput == 1)
            {
                Console.WriteLine("You are converting £ to $.");
                return exchangeRate;
            }
            else
            {
                Console.WriteLine("You are converting $ to £.");
                return 100/(exchangeRate * 100);
            }
        }

        /// <summary>
        /// Ask the user how much currency they wish to convert.
        /// </summary>
        /// <returns>Amount of currency user wants to convert.</returns>
        static int GetCurrencyAmount()
        {
            // Get user input.
            Console.WriteLine("How much money do you wish to convert? Full numbers only.");
            bool isInt = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isInt || !(0 < userInput && userInput <= int.MaxValue))
            {
                Console.WriteLine("How much money do you wish to convert? Full numbers only.");
                isInt = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }

        /// <summary>
        /// Prints the amount of currency after conversion.
        /// </summary>
        /// <param name="currencyAmount">Amount of currency before conversion.</param>
        /// <param name="exchangeRate">Current exchange rate.</param>
        static void PrintConvertedAmount(int currencyAmount, double exchangeRate)
        {
            // Print converted amount rounded to 2 dp.
            Console.WriteLine(Math.Round(currencyAmount * exchangeRate, 2, MidpointRounding.AwayFromZero));
        }

        /// <summary>
        /// Ask the user if they want to go again.
        /// </summary>
        /// <returns>bool of user input.</returns>
        static bool GoAgain()
        {
            // Ask for user input.
            Console.WriteLine("Do you wish to go again? [yes/no]");
            string userInput = Console.ReadLine().ToLower();
            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Do you wish to go again? [yes/no]");
                userInput = Console.ReadLine();
            }
            // Does user want to go again?
            if (userInput == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
