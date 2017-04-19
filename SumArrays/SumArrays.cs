namespace SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var resultLenght = Math.Max(arr1.Length, arr2.Length);

            int[] result = new int[resultLenght];

            for (int i = 0; i < resultLenght; i++)
            {
                result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
