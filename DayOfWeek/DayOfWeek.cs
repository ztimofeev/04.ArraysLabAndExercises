using System.Runtime.InteropServices;

namespace DayOfWeek
{
    using System;

    public class DayOfWeek
    {
        public static void Main()
        {
            string[] days = new[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            var day = int.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
