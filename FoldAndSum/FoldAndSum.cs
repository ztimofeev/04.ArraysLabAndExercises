using System.Collections.Generic;

namespace FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = nums.Length / 4;

            var leftFold = ArrayCutter(nums, k).Reverse();
            var rightFold = ArrayCutter(nums.Reverse().ToArray(), k);

            int[] concatLeftRightFolds = leftFold.Concat(rightFold).ToArray();

            var middleArr = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                middleArr[i] = nums[i + k];
            }
            
            var resultArr = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                resultArr[i] = concatLeftRightFolds[i] + middleArr[i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }

        private static int[] ArrayCutter(int[] n, int x)
        {
            var output = new int[x];

            for (int i = 0; i < x; i++)
            {
                output[i] = n[i];
            }

            return output;
        }
    }
}
