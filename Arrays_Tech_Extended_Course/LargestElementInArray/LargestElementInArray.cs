namespace LargestElementInArray
{
    using System;

    public class LargestElementInArray
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            var largestNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > largestNumber)
                {
                    largestNumber = arr[i];
                }
            }

            Console.WriteLine(largestNumber);
        }
    }
}
