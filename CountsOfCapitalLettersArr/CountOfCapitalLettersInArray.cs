namespace CountsOfCapitalLettersArr
{
    using System;
    using System.Linq;

    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            var counter = 0;


            for (int i = 0; i < text.Length; i++)
            {
                //var word = text[i];
                if (IsLetter(text[i]) && text[i] != text[i].ToLower())
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        public static bool IsLetter(string a)
        {
            char[] word = a.ToCharArray();
            if (word.Length == 1)
            {
                return true;
            }
            return false;
        }
    }
}
