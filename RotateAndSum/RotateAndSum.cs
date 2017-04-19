
namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());

            var len = n.Length;

            var sum = new int[len];

            for (int i = 1; i <= rotations; i++)
            {
                var lastIndex = n[len - 1];

                for (int j = len - 1; j > 0; j--)
                {
                    n[j] = n[j - 1];
                }
                n[0] = lastIndex;

                for (int j = 0; j < len; j++)
                {
                    sum[j] += n[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
