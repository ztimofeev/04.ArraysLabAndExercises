namespace Altitude
{
    using System;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            var rules = Console.ReadLine().Split(' ').ToArray();

            var altitude = long.Parse(rules[0]);

            for (int i = 1; i < rules.Length; i += 2)
            {
                long temp = 0;
                if (rules[i] == "down")
                {
                    temp = long.Parse(rules[i + 1]);
                    altitude -= temp;
                    if (altitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        return; ;
                    }
                }
                else if (rules[i] == "up")
                {
                    temp = long.Parse(rules[i + 1]);
                    altitude += temp;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
