namespace CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (num.Length > 1)
            {
                var condense = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    condense[i] = num[i] + num[i + 1];
                }
                
                num = condense;
                
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
