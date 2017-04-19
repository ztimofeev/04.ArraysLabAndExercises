namespace LargestCommanEnd_2_Version
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var firstSentence = Console.ReadLine().Split().ToArray();
            var secondSentence = Console.ReadLine().Split().ToArray();

            var minLen = Math.Min(firstSentence.Length, secondSentence.Length);

            if (firstSentence[0] != secondSentence[0])
            {
                firstSentence = firstSentence.Reverse().ToArray();
                secondSentence = secondSentence.Reverse().ToArray();
            }
           
            var count = GetLargestCommonEndCount(firstSentence, secondSentence, minLen);
            Console.WriteLine(count);
        }

        public static int GetLargestCommonEndCount(string[] firste, string[] second, int len)
        {
            var count = 0;
            for (int i = 0; i < len; i++)
            {
                if (firste[i] == second[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
