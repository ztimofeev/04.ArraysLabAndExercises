namespace IncreasingSequenceInArray
{
    using System;
    using System.Linq;

    public class IncreasingSequenceInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = "Yes";

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    result = "No";
                }
            }

            Console.WriteLine(result);
        }
    }
}
