using System.Linq;

namespace CountOfOddNumbersInArray
{
    using System;
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var countOdds = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    countOdds++;
                }
            }

            Console.WriteLine(countOdds);
        }
    }
}
