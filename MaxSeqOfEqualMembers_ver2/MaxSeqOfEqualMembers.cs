namespace MaxSeqOfEqualMembers_ver2
{
    using System;
    using System.Linq;

    public class MaxSeqOfEqualMembers
    {
        public static void Main()
        {
            var numbs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var startIndex = 0;
            var currentLen = 1;
            var bestIndex = 0;
            var bestLen = 0;

            for (int i = 1; i < numbs.Length; i++)
            {
                if (numbs[i] == numbs[startIndex])
                {
                    currentLen++;
                    if (currentLen > bestLen)
                    {
                        bestIndex = startIndex;
                        bestLen = currentLen;
                    }
                }
                else
                {
                    startIndex = i;
                    currentLen = 1;
                }
            }

            var maxSequence = new int[bestLen];

            for (int i = 0; i < bestLen; i++)
            {
                maxSequence[i] = numbs[bestIndex];
            }

            Console.WriteLine(string.Join(" ", maxSequence));
        }
    }
}
