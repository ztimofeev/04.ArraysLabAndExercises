namespace ArrayElem_sEqualToIndex
{
    using System;
    using System.Linq;

    public class ArrayElem_sEqualToIndex
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var len = numbers.Length;

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
