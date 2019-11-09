using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // n1, n2 are two adjacent values in the series, starting at 0,1
            // Fibonacci = 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
            int n1 = 0;
            for (int n2 = 1; n1 < 1000; n1 = (n2 = n1 + n2) - n1)
            {
                Console.Write("{0}, ", n1);
            }
            Console.ReadLine();
        }
    }
}
