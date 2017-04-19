namespace RotateArray
{
    using System;

    public class RotateArray
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();

            string[] rotatedArray = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (i == words.Length - 1)
                {
                    rotatedArray[0] = words[i];
                    
                }
                else
                {
                    rotatedArray[i + 1] = words[i];
                }
            }

            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
