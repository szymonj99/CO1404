using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to 10.
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}, ", i);
            }

            // Clear console after user presses return and show next for loop.
            Console.ReadLine();
            Console.Clear();

            // Print odd numbers from 9 to 49.
            for (int i = 9; i <= 49; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

            // Clear console after user presses return and show next for loop.
            Console.ReadLine();
            Console.Clear();

            // Print even numbers from 100 down to 50 in reverse order. NOT including 50.
            for (int i = 100; i > 50; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

            // Stop console from closing immediately.
            Console.ReadLine();
        }
    }
}
