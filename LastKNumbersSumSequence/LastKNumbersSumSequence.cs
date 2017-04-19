namespace LastKNumbersSumSequence
{
    using System;

    public class LastKNumbersSumSequence
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        arr[i] += arr[j];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
