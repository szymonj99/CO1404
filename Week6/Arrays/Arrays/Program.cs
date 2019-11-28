using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            // Store weekdays in an array.
            string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            // Print out all elements of the array.
            foreach (string day in weekdays)
            {
                // Print whole day
                //Console.WriteLine(day);
                // Print first char only.
                //Console.WriteLine(day[0]);
                // Check if first letter is S or T, and print
                if (day[0] == 'S' || day[0] == 'T')
                {
                    Console.WriteLine(day);
                }
            }
            Console.WriteLine();

            // Array from user input
            Console.WriteLine("How many integers do you want in an array?");
            int userArayLength = int.Parse(Console.ReadLine());
            int[] userArray = new int[userArayLength];
            int userArrayIndex = 0;
            foreach (int userNum in userArray)
            {
                Console.WriteLine("Input {0} number.", userArrayIndex + 1);
                userArray[userArrayIndex] = int.Parse(Console.ReadLine());
                userArrayIndex++;
            }
            Console.WriteLine();

            // Display user array in reverse order.
            Console.WriteLine("Displaying array in reverse order.");
            for (int i = userArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userArray[i]);
            }
            Console.WriteLine();

            // Sort the user array and display it.
            List<int> userList = userArray.ToList<int>();
            userList.Sort();
            userArray = userList.ToArray<int>();
            Console.WriteLine("Displaying sorted array in ascending order.");
            foreach (int userNumber in userArray)
            {
                Console.WriteLine(userNumber);
            }
            Console.WriteLine();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
