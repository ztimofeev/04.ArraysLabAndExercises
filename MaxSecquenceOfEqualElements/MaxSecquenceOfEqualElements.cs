namespace MaxSecquenceOfEqualElements
{
    using System;
    using System.Linq;

    public class MaxSecquenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var maxCount = 0;
            var bestValue = 0;
            var count = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestValue = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.WriteLine(TextMacker(bestValue.ToString(), maxCount));
        }

        public static string TextMacker(string txt, int n)
        {
            var output = "";
            for (int i = 0; i < n; i++)
            {
                output += txt + " ";
            }

            return output;
        }
    }
}
