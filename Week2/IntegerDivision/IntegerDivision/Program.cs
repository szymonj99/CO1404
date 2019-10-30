using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user what measurement they want to operate in and ask for the temperature, and print the temperature in the other unit also.
            string userUnit = DecideMeasurement();
            int userTemperature = GetTemperature(userUnit);
            if (userUnit == "celcius")
            {
                Console.WriteLine("{0} {1} is {2} {3}", userTemperature, userUnit, ConvertUnit("celcius", userTemperature), "fahrenheit");
            }
            else
            {
                Console.WriteLine("{0} {1} is {2} {3}", userTemperature, userUnit, ConvertUnit("fahrenheit", userTemperature), "celcius");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Get the temperature input by user.
        /// </summary>
        /// <param name="measurement">What degrees the temperature is in. Celcius or Fahrenheit.</param>
        /// <returns>Temperature input by user.</returns>
        static int GetTemperature(string measurement)
        {
            Console.Write("Please input the temperature in {0}. Keep it a whole number. It also cannot go below absolute zero: ", measurement);
            // Validate user's input.
            bool isInt = int.TryParse(Console.ReadLine(), out int temperature);
            // Limit temperature to absolute zero - 0K, -273.15 C, -460 F.
            const int minCelciusTemp = -273;
            const int minFahrenheitTemp = -460;
            if (measurement.ToLower() == "celcius")
            {
                while (!isInt || !(minCelciusTemp <= temperature && temperature <= int.MaxValue))
                {
                    Console.Write("Please input the temperature in {0}. Keep it a whole number. It also cannot go below absolute zero: ", measurement);
                    isInt = int.TryParse(Console.ReadLine(), out temperature);
                }
            }
            else if (measurement.ToLower() == "fahrenheit")
            {
                while (!isInt || !(minFahrenheitTemp <= temperature && temperature <= int.MaxValue))
                {
                    Console.Write("Please input the temperature in {0}. Keep it a whole number. It also cannot go below absolute zero: ", measurement);
                    isInt = int.TryParse(Console.ReadLine(), out temperature);
                }
            }

            return temperature;
        }

        /// <summary>
        /// Ask user to input what measurement unit they want to input. Celcius or fahrenheit.
        /// </summary>
        /// <returns>USer's chosen unit of measurement.</returns>
        static string DecideMeasurement()
        {
            Console.Write("Do you wish to operate in celcius or fahrenheit? Please type your answer: ");
            string userInput = Console.ReadLine().ToLower();
            while (userInput != "celcius" && userInput != "fahrenheit")
            {
                userInput = Console.ReadLine().ToLower();
                Console.Write("Do you wish to operate in celcius or fahrenheit? Please type your answer: ");
            }
            return userInput;
        }

        /// <summary>
        /// Converts celcius to fahrenheit and fahrenheit to celcius.
        /// </summary>
        /// <param name="currentUnit">The user's currently chosen unit.</param>
        /// <returns>Temperature in the other unit.</returns>
        static double ConvertUnit(string currentUnit, int currentTemp)
        {
            if (currentUnit == "celcius")
            {
                return Math.Round(currentTemp * (9f / 5f) + 32, 0, MidpointRounding.AwayFromZero);
            }
            else
            {
                return Math.Round((currentTemp - 32f) * (5f / 9f), 0, MidpointRounding.AwayFromZero);
            }
        }
    }
}
