namespace Phonebook
{
    using System;


    public class Phonebook
    {
        public static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var names = Console.ReadLine().Split(' ');

            var len = names.Length;

            var newName = Console.ReadLine();

            while (newName != "done")
            {
                for (int i = 0; i < len; i++)
                {
                    if (names[i] == newName)
                    {
                        Console.WriteLine("{0} -> {1}", names[i], phoneNumbers[i]);
                    }
                }

                newName = Console.ReadLine();
            }
        }
    }
}
