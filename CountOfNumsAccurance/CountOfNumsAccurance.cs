namespace CountOfNumsAccurance
{
    using System;
    using System.Linq;

    public class CountOfNumsAccurance
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] count = new int[1001];

            foreach (var number in numbers)
            {
                count[number]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
        }
    }
}
