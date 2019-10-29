using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare known bad value for bad return value.
            int badReturnVal = -1;
            // Ask user to input their height, parse it as int and display it.
            int userHeight = IntParseDetail(GetUserDetail("height"));
            // While user doesn't input an integer, retry input.
            while (userHeight == badReturnVal)
            {
                userHeight = IntParseDetail(GetUserDetail("height"));
            }
            Console.WriteLine("You are {0} cm.", userHeight);

            // How many neighbours to ask for information?
            int neighboursToAsk = 2;
            for (int neighbourNumber = 1; neighbourNumber <= neighboursToAsk; neighbourNumber++)
            {
                Console.WriteLine("The height for neighbour {0} is {1} cm.", neighbourNumber, GetNeighbourHeight(neighbourNumber));
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user to input their name.
        /// </summary>
        /// <returns>The user's input.</returns>
        static string GetUserDetail(string detail)
        {
            Console.WriteLine("What is your {0}?", detail);
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask the user to input the detail for one of their neighbours.
        /// </summary>
        /// <param name="neighbourNumber">What neighbour number you are getting information for.</param>
        /// <param name="detail">What do you wish to know about the neighbour.</param>
        /// <returns>User's input.</returns>
        static string GetNeighbourDetail(int neighbourNumber, string detail)
        {
            Console.WriteLine("What is the {0} of your neighbour {1} in cm?", detail, neighbourNumber);
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask for neighrbour's height and parse as int.
        /// </summary>
        /// <param name="neighbourNumber">What neighbour you want to ask for information.</param>
        /// <returns>Neighbour's height.</returns>
        static int GetNeighbourHeight(int neighbourNumber)
        {
            int neighbourHeight = IntParseDetail(GetNeighbourDetail(neighbourNumber, "height"));
            while (neighbourHeight == -1)
            {
                neighbourHeight = IntParseDetail(GetNeighbourDetail(neighbourNumber, "height"));
            }
            return neighbourHeight;
        }

        /// <summary>
        /// Try to parse a detail passed as string to an integer. EG. Age.
        /// </summary>
        /// <param name="detail">User's input detail to be parsed as integer.</param>
        /// <returns>Parsed integer, or -1 if passed argument was not an integer.</returns>
        static int IntParseDetail(string detail)
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
