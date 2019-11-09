using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display all numbers of counter.
            int counter = 1;
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Have some space.
            Console.WriteLine();

            // Reset counter.
            counter = 0;
            // Print even numbers in ascending order.
            while (counter <= 100)
            {
                // Display only even numbers.
                if (counter % 2 == 0)
                {
                    Console.Write("{0}, ", counter);
                }
                counter++;
            }

            // Have some space.
            Console.WriteLine();
            Console.WriteLine();

            // Reset counter to max value.
            counter = 100;
            // Print even numbers in descending order.
            while (counter >= 0)
            {
                // Display only even numbers.
                if (counter % 2 == 0)
                {
                    Console.Write("{0}, ", counter);
                }
                counter--;
            }

            Console.ReadLine();
        }
    }
}
