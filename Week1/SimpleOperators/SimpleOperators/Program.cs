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

            // How many numbers total will we collect, including the user and neighbours.
            int peopleToAsk = 3;
            // Create array to store objects.
            Person[] people = new Person[peopleToAsk];

            // Create user object.
            Person user = new Person();
            // Ask user if they want to input height in feet and inches, inches, or cm.
            const int availableInputOptions = 3;
            bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isNumber || !(1 <= userInput && userInput <= availableInputOptions))
            {
                Console.WriteLine("What would you like to input your height in?\n" +
                "1. cm\n" +
                "2. inches\n" +
                "3. feet and inches.");
                isNumber = int.TryParse(Console.ReadLine(), out userInput);
            }

            // Ask for input of type that user selected.
            switch (userInput)
            {
                case 1: // Ask for height in cm.
                    {
                        break;
                    }
                case 2: // Ask for height in inches.
                    {
                        break;
                    }
                case 3: // Ask for height in feet and inches.
                    {
                        break;
                    }
            }

            // Ask user to input their height, parse it as int and display it.
            user.height = IntParseDetail(InputUserDetail("height"));
            // While user doesn't input an integer, retry input.
            while (user.height == badReturnVal)
            {
                user.height = IntParseDetail(InputUserDetail("height"));
            }
            // Store user object in array.
            people[0] = user;
            Console.WriteLine("You are {0} cm tall.", user.height);

            // Create neighbour objects.
            Person neighbour1 = new Person();
            Person neighbour2 = new Person();

            // What neighbour we are currently asking for height.
            int neighbourNumber = 1;

            // Ask for neighbour height.
            neighbour1.height = InputNeighbourHeight(neighbourNumber);
            Console.WriteLine("The height for neighbour {0} is {1} cm.", neighbourNumber, neighbour1.height);
            // Store neighrbour object in people array.
            people[neighbourNumber] = neighbour1;
            neighbourNumber++;

            // Ask for neighbour height.
            neighbour2.height = InputNeighbourHeight(neighbourNumber);
            Console.WriteLine("The height for neighbour {0} is {1} cm.", neighbourNumber, neighbour2.height);
            // Store neighrbour object in people array.
            people[neighbourNumber] = neighbour2;

            // Print average height for all objects in array.
            Console.WriteLine("Average height: {0} cm.", GetAverageHeight(people));
            // Print average height in inchesm rounded to two decimal points.
            Console.WriteLine("Average height: {0} inches.", Math.Round(GetAverageHeight(people) / 2.54, 2, MidpointRounding.AwayFromZero));
            // Print average height in feet and inches.
            Console.WriteLine("Average height: {0} feet {1} inches.", Math.Floor(Math.Round(GetAverageHeight(people) / 2.54, 2, MidpointRounding.AwayFromZero) / 12), Math.Round(GetAverageHeight(people) / 2.54, 2, MidpointRounding.AwayFromZero) % 12);

            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user to input their name.
        /// </summary>
        /// <returns>The user's input.</returns>
        static string InputUserDetail(string detail)
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
        static string InputNeighbourDetail(int neighbourNumber, string detail)
        {
            Console.WriteLine("What is the {0} of your neighbour {1} in cm?", detail, neighbourNumber);
            return Console.ReadLine();
        }

        /// <summary>
        /// Ask for neighrbour's height and parse as int.
        /// </summary>
        /// <param name="neighbourNumber">What neighbour you want to ask for information.</param>
        /// <returns>Neighbour's height.</returns>
        static int InputNeighbourHeight(int neighbourNumber)
        {
            int neighbourHeight = IntParseDetail(InputNeighbourDetail(neighbourNumber, "height"));
            while (neighbourHeight == -1)
            {
                neighbourHeight = IntParseDetail(InputNeighbourDetail(neighbourNumber, "height"));
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

        /// <summary>
        /// Gets the average height from people array.
        /// </summary>
        /// <param name="peopleArray">An array that stores Person objects with a height property.</param>
        /// <returns>Double of the average height.</returns>
        static double GetAverageHeight(Array peopleArray)
        {
            int runningHeightTotal = 0;
            foreach (Person person in peopleArray)
            {
                runningHeightTotal += person.height;
            }
            return runningHeightTotal/peopleArray.Length;
        }
    }
}
