using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesOperatorsConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user how many items they are buying and create array of that length.
            Product[] itemArray = new Product[InputItemQuantity()];

            // Ask user to input price for all items in array.
            InputItemPrice(itemArray);

            // Calculate price of the items and output to console.
            Console.WriteLine("Total price for {0} item/s is £{1}.", itemArray.Length, CalculateTotalPrice(itemArray));

            // Calculate Tax.
            const double taxPercentage = 20;
            Console.WriteLine("Tax to pay: £{0}", CalculateTax(CalculateTotalPrice(itemArray), taxPercentage));

            // Calculate total price
            Console.WriteLine("Total price to pay: £{0}", CalculateTax(CalculateTotalPrice(itemArray), taxPercentage) + CalculateTotalPrice(itemArray));

            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user how many items in total they wish to buy.
        /// </summary>
        /// <returns>Int of user input.</returns>
        static int InputItemQuantity()
        {
            Console.Write("How many items do you wish to purchase?: ");
            // Try to parse user input as an int.
            bool isInt = int.TryParse(Console.ReadLine(), out int numOfItems);
            while (!isInt || !(1 <= numOfItems && numOfItems <= int.MaxValue))
            {
                Console.Write("How many items do you wish to purchase?: ");
                isInt = int.TryParse(Console.ReadLine(), out numOfItems);
            }
            Console.WriteLine("You are buying {0} items.", numOfItems);
            return numOfItems;
        }

        /// <summary>
        /// Ask the user to input a price for every item inthe itemArray array.
        /// </summary>
        /// <param name="array">The array that stores the items user wants to buy.</param>
        /// <returns>An array with all the prices input.</returns>
        static Array InputItemPrice(Array array)
        {
            int positionCounter = 1;
            double minValue = 0.01;
            // For every index in the array, ask user to input the price to store for the item at that index.
            foreach (Product product in array)
            {
                Console.Write("What is the price for item {0} in £: ", positionCounter);
                // Try to parse user input as a double.
                bool isDouble = double.TryParse(Console.ReadLine(), out double itemPrice);
                while (!isDouble || !(minValue <= itemPrice && itemPrice <= double.MaxValue))
                {
                    Console.Write("What is the price for item {0} in £: ", positionCounter);
                    isDouble = double.TryParse(Console.ReadLine(), out itemPrice);
                }//Create new object to replace null product with.
                Product newProduct = new Product();
                newProduct.price = itemPrice;
                array.SetValue(newProduct, positionCounter - 1);
                positionCounter++;
            }
            return array;
        }
        
        /// <summary>
        /// Calculates the total price of all items in the itemArray array.
        /// </summary>
        /// <param name="itemArray">An array that stores all the items user is buying.</param>
        /// <returns>Double of the total price.</returns>
        static double CalculateTotalPrice(Array itemArray)
        {
            // Add up the price for all items in the array.
            double runningPriceTotal = 0;
            foreach (Product product in itemArray)
            {
                runningPriceTotal += product.price;
            }
            return runningPriceTotal;
        }

        /// <summary>
        /// Calculate the tax for total cost of items.
        /// </summary>
        /// <param name="price">Current total price for all items.</param>
        /// <param name="taxPercent">Tax percentage to which multiply the price by.</param>
        /// <returns>Double of the tax to pay on top of the price.</returns>
        static double CalculateTax(double price, double taxPercent)
        {
            // Calculate tax based on price and tax percent.
            return price * (taxPercent / 100);
        }
    }
}
