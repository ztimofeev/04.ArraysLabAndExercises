namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var firstString = Console.ReadLine().Split(' ').ToArray();
            var secondString = Console.ReadLine().Split(' ').ToArray();

            var result = CommonEnd(firstString, secondString);
            Console.WriteLine(result);
        }

        public static int CommonEnd(string[] a, string[] b)
        {
            var leftCounter = 0;
            var rightCounter = 0;
            var shortLen = 0;

            if (a.Length <= b.Length)
            {
                shortLen = a.Length;
            }
            else
            {
                shortLen = b.Length;
            }

            for (int i = 0; i < shortLen; i++)
            {
                if (a[i] == b[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < shortLen; i++)
            {
                if (a[a.Length - 1 - i] == b[b.Length - 1 - i])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }

            if (leftCounter >= rightCounter)
            {
                return leftCounter;
            }
            return rightCounter;
        }
    }
}
