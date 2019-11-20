using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedNumberGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 9;
            int height = 9;
            DrawGrid(width, height);
            Console.ReadLine();
        }

        static void DrawGrid(int width, int height)
        {
            int currentNumber = 1;
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write("{0:00} ", currentNumber);
                    currentNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}
