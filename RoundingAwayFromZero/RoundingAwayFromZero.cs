namespace RoundingAwayFromZero
{
    using System;
    using System.Linq;

    public class RoundingAwayFromZero
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                var rounded = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {rounded}");
            }
        }
    }
}
