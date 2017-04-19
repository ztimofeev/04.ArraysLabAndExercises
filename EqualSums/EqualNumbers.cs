namespace EqualSums
{
    using System;
    using System.Linq;

    public class EqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbers.Length > 1)
            {
                bool noCase = true;

                for (int i = 0; i < numbers.Length; i++)
                {
                    var leftSum = GetSumOfElements(numbers, 0, i);
                    var rightSum = GetSumOfElements(numbers, i + 1, numbers.Length);
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(i);
                        noCase = false;
                    }
                }
                if (noCase)
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        public static int GetSumOfElements(int[] num, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                sum += num[i];
            }
            return sum;
        }
    }
}
