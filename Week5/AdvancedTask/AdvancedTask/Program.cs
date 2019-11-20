using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask
{
    public enum Shapes { triangle, pyramid, vshape };

    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int userInput = -1;
            string userShape = "blank";
            int height = -1;
            do
            {
                Console.WriteLine("What shape would you like to draw?\n" +
                    "1. triangle\n" +
                    "2. pyramid\n" +
                    "3. v-shape");
                isInt = int.TryParse(Console.ReadLine(), out userInput);
            }
            while (userInput > Enum.GetNames(typeof(Shapes)).Length || userInput < 1);
            userShape = Enum.GetName(typeof(Shapes), userInput);

            do
            {
                Console.WriteLine("How big do you want the shape to be?");
                
            }

            switch (userShape)
            {
                case "triangle":
                    {
                        DrawShape("triangle", userInput);
                        break;
                    }
            }
            Console.ReadLine();
        }

        static void DrawShape(string shape, int height)
        {
            switch (shape)
            {
                case "triangle":
                    {
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "pyramid":
                    {
                        int spacing = height;
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < spacing - i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k <= (2 * i); k++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                //case Shapes.vshape:
                //    {
                //        int lineWidth = 4;
                //        int height = 5;
                //        for (int i = 0; i < 10; i++)
                //        {

                //        }
                //        break;
                //    }
                default:
                    {
                        break;
                    }
            }
        }

        static string AskForShape()
        {
            return "";
        }
    }
}
