namespace Last3ConsecutiveNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Last3ConsecutiveNumbers
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split().ToArray();

            var len = text.Length;
            var counter = 1;

            for (int i = len - 1; i > 0; i--)
            {

                if (text[i] == text[i - 1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        for (int j = 0; j < counter; j++)
                        {
                            Console.Write(text[i] + " ");
                        }
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }
    }
}
