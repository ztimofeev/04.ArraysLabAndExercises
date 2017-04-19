namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            var inputString = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < inputString.Length / 2; i++)
            {
                var temp = inputString[i];
                inputString[i] = inputString[inputString.Length - i - 1];
                inputString[inputString.Length - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", inputString));
        }
    }
}
