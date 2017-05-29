namespace ArraySymmetry
{
    using System;
    using System.Linq;

    public class ArraySymmetry
    {
        public static void Main()
        {
            var strArray = Console.ReadLine().Split(' ').ToArray();

            var result = "Yes";

            for (int i = 0; i < strArray.Length / 2; i++)
            {
                if (strArray[i] != strArray[strArray.Length - 1 - i])
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
