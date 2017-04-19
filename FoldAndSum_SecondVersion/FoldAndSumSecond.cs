namespace FoldAndSum_SecondVersion
{
    using System;
    using System.Linq;

    public class FoldAndSumSecond
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = nums.Length / 4;

            var leftFold = new int[k];
            var rightFold = new int[k];
            var middle = new int[2 * k];

            for (int i = 0; i < 4 * k; i++)
            {
                if (i < k)
                {
                    leftFold[i] = nums[i];
                }
                else if (i < 3 * k)
                {
                    middle[i - k] = nums[i];
                }
                else
                {
                    rightFold[i - 3 * k] = nums[i];
                }
            }
            var revLeft = leftFold.Reverse();
            var revRight = rightFold.Reverse();
            var concatLeftRight = revLeft.Concat(revRight).ToArray();

            var result = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                result[i] = concatLeftRight[i] + middle[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
