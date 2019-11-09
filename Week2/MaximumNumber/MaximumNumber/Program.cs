using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise int array of length quantityOfNumbers.
            const int quantityOfNumbers = 5;
            int[] numbers = new int[quantityOfNumbers];
            // Fill every index of array with int of user input.
            for (int number = 1; number <= 5; number++)
            {
                numbers[number - 1] = GetNumber(number);
            }

            // Get the biggest number in the array.
            // Using method to get the max number only if array is int.
            Console.WriteLine("Biggest number is: {0}.", numbers.Max());

            Console.ReadLine();
        }
        
        /// <summary>
        /// Ask the user to input a series of integers.
        /// </summary>
        /// <param name="numberIndex">The index of the number currently being asked.</param>
        /// <returns>Int of user input.</returns>
        static int GetNumber(int numberIndex)
        {
            Console.WriteLine("Input number {0}.", numberIndex);
            bool isInt = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isInt)
            {
                Console.WriteLine("Input number {0}.", numberIndex);
                isInt = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
    }
}
