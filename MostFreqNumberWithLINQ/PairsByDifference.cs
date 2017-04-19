namespace MostFreqNumberWithLINQ
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var maxFreq = numbers[0];
            var maxCount = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers.Count(x => x == numbers[i]);
                if (current > maxCount)
                {
                    maxCount = current;
                    maxFreq = numbers[i];
                }
            }

            Console.WriteLine(maxFreq);
        }
    }
}
