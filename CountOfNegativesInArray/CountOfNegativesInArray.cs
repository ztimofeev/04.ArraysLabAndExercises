namespace CountOfNegativesInArray
{
    using System;

    public class CountOfNegativesInArray
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            var counter = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
