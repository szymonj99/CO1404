using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
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

            // Sort the array using ONLY if statements.
            SortArray(numbers);

            // Output sorted array to console.
            foreach (int number in numbers)
            {
                Console.Write("{0} ", number);
            }

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

        /// <summary>
        /// Recursively sort an int array. Hardcoded 5 max values.
        /// </summary>
        /// <param name="numberArray">An array of integers of length 5 maximum.</param>
        /// <returns>Sorted int array.</returns>
        static void SortArray(int[] numberArray)
        {
            // Initialise third variable to aid in replacing two values.
            int placeholder;

            if (numberArray[1] < numberArray[0])
            {
                placeholder = numberArray[1];
                numberArray[1] = numberArray[0];
                numberArray[0] = placeholder;
            }
            if (numberArray[2] < numberArray[1])
            {
                placeholder = numberArray[2];
                numberArray[2] = numberArray[1];
                numberArray[1] = placeholder;
            }
            if (numberArray[3] < numberArray[2])
            {
                placeholder = numberArray[3];
                numberArray[3] = numberArray[2];
                numberArray[2] = placeholder;
            }
            if (numberArray[4] < numberArray[3])
            {
                placeholder = numberArray[4];
                numberArray[4] = numberArray[3];
                numberArray[3] = placeholder;
            }

            // This needs to be run at the end.
            // If the array is not in ascending order, run sort array again.
            if (!(numberArray[0] <= numberArray[1] && numberArray[1] <= numberArray[2] && numberArray[2] <= numberArray[3] && numberArray[3] <= numberArray[4]))
            {
                SortArray(numberArray);
            }
        }
    }
}
