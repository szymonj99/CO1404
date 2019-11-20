using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Draw an L shape.
            int width = 5;
            int height = 10;
            int spaces = 0;
            DrawShape(width, height, spaces);
            width = 15;
            height = 4;
            DrawShape(width, height, spaces);

            // Spacing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
            }

            // Draw T shape.
            DrawShape(width, height, spaces);
            width = 5;
            height = 10;
            spaces = 5;
            DrawShape(width, height, spaces);

            Console.ReadLine();
        }

        static void DrawShape(int width, int height, int spaces)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < width; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
