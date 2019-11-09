using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Max years allowed by documentation.
            const int yearMin = 1;
            const int yearMax = 9999;
            bool isInt = false;
            int userYear;
            // Ask for user input.
            do
            {
                Console.WriteLine("Input a year from {0} to {1}.", yearMin, yearMax);
                isInt = int.TryParse(Console.ReadLine(), out userYear);
            }
            while (!isInt || userYear < yearMin || userYear > yearMax);

            // Iterate over months, and show short month names
            int currentDay;
            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine();
                Console.WriteLine(new DateTime(userYear, month, 1).ToString("MMMM"));

                // Write the day's short name as heading below month name.
                for (int day = 1; day <= 7; day++)
                {
                    Console.Write("{0} ", new DateTime(userYear, month, day).ToString("ddd"));
                }
                Console.WriteLine();

                // Iterate over all days in month, and align in columns.
                currentDay = 1;
                while (currentDay <= DateTime.DaysInMonth(userYear, month))
                {
                    if (currentDay % 7 == 1 && currentDay != 1)
                    {
                        Console.WriteLine();
                    }
                    Console.Write("{0:D2}  ", currentDay);
                    currentDay++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
