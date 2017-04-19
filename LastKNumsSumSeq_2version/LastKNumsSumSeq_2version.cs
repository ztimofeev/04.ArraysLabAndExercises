namespace LastKNumsSumSeq_2version
{
    using System;

    public class LastKNumsSumSeq_2version
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];

            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                //добра идея е като първи индекс да се подаде на метода следната променлива:
                // var start = Math.Max(0, i - k), като така си гарантираме, че ще започваме винаги от нулта.
                seq[i] = SunKNumbers(seq, i - k, i);
            }

            Console.WriteLine(string.Join(" ", seq));
        }

        private static long SunKNumbers(long[] arr, int startIndex, int endIndex)
        {
            long sum = 0;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (i >= 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
    }
}
