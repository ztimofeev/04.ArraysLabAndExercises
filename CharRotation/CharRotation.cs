namespace CharRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            var symbols = Console.ReadLine().ToCharArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = symbols.Length;
            char modSymbol;
            var result = new char[len];

            for (int i = 0; i < len; i++)
            {
                int charToInt = (int)symbols[i];

                var action = 0;

                if (numbers[i] % 2 == 0)
                {
                    action = charToInt - numbers[i];
                    modSymbol = (char)(action);
                }
                else
                {
                    action = charToInt + numbers[i];
                    modSymbol = (char)action;
                }

                result[i] = modSymbol;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
