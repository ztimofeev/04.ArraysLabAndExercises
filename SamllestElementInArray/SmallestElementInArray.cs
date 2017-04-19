namespace SmallestElementInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbres = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var smallest = int.MaxValue;

            foreach (var number in numbres)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
