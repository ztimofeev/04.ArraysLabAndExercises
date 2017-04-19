namespace CountOccureOfLargerNumInArr
{
    using System;
    using System.Linq;

    public class CountOccureOfLargerNumInArr
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
