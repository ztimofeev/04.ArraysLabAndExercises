namespace MultiplyArrayOfDoubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplyArrayOfDoubles
    {
        public static void Main()
        {
            var numbres = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbres.Length; i++)
            {
                numbres[i] *= p;
            }

            Console.WriteLine(string.Join(" ", numbres));
        }
    }
}
