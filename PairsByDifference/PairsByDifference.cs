namespace PairsByDifference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var diff = int.Parse(Console.ReadLine());

            int countPairs = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (Math.Abs(numbers[i] - numbers[j]) == diff)
                    {
                        countPairs++;
                    }
                }
            }

            Console.WriteLine(countPairs);
        }
    }
}
