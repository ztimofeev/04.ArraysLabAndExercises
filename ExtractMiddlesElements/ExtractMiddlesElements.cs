namespace ExtractMiddlesElements
{
    using System;
    using System.Linq;

    public class ExtractMiddlesElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int midLen = numbers.Length / 2;

            if (numbers.Length == 1)
            {
                Console.WriteLine("{" + $" {numbers[0]} " + "}");
            }
            else if(numbers.Length % 2 == 0)
            {

                Console.WriteLine("{" + $" { numbers[midLen - 1] }, {numbers[midLen]} " + "}");
            }
            else
            {
                Console.WriteLine("{" + $" {numbers[midLen -1]}, {numbers[midLen]}, {numbers[midLen + 1]} " + "}");
            }
        }
    }
}
