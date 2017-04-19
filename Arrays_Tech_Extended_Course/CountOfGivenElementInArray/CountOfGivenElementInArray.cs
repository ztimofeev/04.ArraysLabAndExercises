namespace CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var num = int.Parse(Console.ReadLine());
            var count = 0;

            foreach (var number in numbers)
            {
                if (number == num)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
