using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year you were born: ");
            // Check if user input is an int.
            bool isInt = int.TryParse(Console.ReadLine(), out int userYear);
            // Define maximum allowed year and limit input between maxYear and current year.
            const int maxYear = 1900;
            while (!isInt || !(maxYear <= userYear && userYear <= DateTime.Now.Year))
            {
                Console.Write("Enter your year you were born: ");
                isInt = int.TryParse(Console.ReadLine(), out userYear);
            }

            // Check if year user was born in is a leap year.
            if (userYear % 4 == 0)
            {
                Console.WriteLine("You were born in a leap year.");
            }
            else
            {
                Console.WriteLine("You were not born in a leap year.");
            }

            // Tell the user if they were born in the same year as me.
            int myYear = 1999;
            if (userYear == myYear)
            {
                Console.WriteLine("You were born in the same year as me!");
            }
            else
            {
                Console.WriteLine("You were not born in the same year as me!");
            }

            // Compare user birth year to my birth year.
            if (userYear == myYear)
            {
                Console.WriteLine("We are the same age!");
            }
            else if(myYear < userYear)
            {
                Console.WriteLine("You are older!");
            }
            else
            {
                Console.WriteLine("I am older!");
            }

            Console.ReadLine();
        }
    }
}
