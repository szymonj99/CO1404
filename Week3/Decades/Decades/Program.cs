using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clear the console.
            Console.Clear();

            // Ask for user's age.
            Console.Write("Enter your age: ");
            bool isInt = int.TryParse(Console.ReadLine(), out int age);
            while (!isInt || age <= 0)
            {
                Console.Write("Enter your age: ");
                isInt = int.TryParse(Console.ReadLine(), out age);
            }

            // Notify user if they are in their thirties.
            if (age >= 0 && age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are not a teenager");
            }

            // Notify user if they are in their twenties.
            if (age >= 20 && age <= 29)
            {
                Console.WriteLine("You are in your twenties");
            }
            else
            {
                Console.WriteLine("You are not in your twenties");
            }

            // Notify user if they are in their thirties.
            if (age >= 30 && age <= 39)
            {
                Console.WriteLine("You are in your thirties");
            }
            else
            {
                Console.WriteLine("You are not in your thirties");
            }

            // Notify user if they are in their fourties.
            if (age >= 40 && age <= 49)
            {
                Console.WriteLine("You are in your fourties");
            }
            else
            {
                Console.WriteLine("You are not in your fourties");
            }

            Console.ReadLine();

            // Restart program.
            Main(null);
        }
    }
}
