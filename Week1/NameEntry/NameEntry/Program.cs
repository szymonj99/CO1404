using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input their name and display it.
            Console.WriteLine("Welcome, {0}.", GetUserDetail("name"));

            // Ask user to input their age, parse it as int and display it.
            int userAge = IntParseUserDetail((GetUserDetail("age")));
            // While user doesn't input an integer, retry input.
            while (userAge == -1)
            {
                userAge = IntParseUserDetail((GetUserDetail("age")));
            }
            Console.WriteLine("You are {0} years old.", userAge);

            Console.ReadLine();            
        }

        /// <summary>
        /// Ask the user to input their name.
        /// </summary>
        /// <returns>The user's input.</returns>
        static string GetUserDetail(string detail)
        {
            Console.WriteLine("Please input your {0}.", detail);
            return Console.ReadLine();
        }

        /// <summary>
        /// Try to parse user's detail passed as string to an integer. EG. Age.
        /// </summary>
        /// <param name="detail">User's input detail to be parsed as integer.</param>
        /// <returns>Parsed integer, or -1 if passed argument was not an integer.</returns>
        static int IntParseUserDetail(string detail)
        {
            try
            {
                // Try to parse the argument as int.
                int parsedInt = int.Parse(detail);
                return parsedInt;
            }
            catch (FormatException)
            {
                // If Try Parse fails, notify user and return -1.
                Console.WriteLine("Not an whole number.");
                return -1;
            }            
        }
    }
}
