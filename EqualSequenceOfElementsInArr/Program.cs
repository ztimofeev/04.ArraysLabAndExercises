namespace EqualSequenceOfElementsInArr
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string isEqual = "Yes";

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] != numbers[i])
                {
                    isEqual = "No";
                }
            }

            Console.WriteLine(isEqual);
        }
    }
}
