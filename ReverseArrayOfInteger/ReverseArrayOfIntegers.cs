namespace ReverseArrayOfIntegers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
