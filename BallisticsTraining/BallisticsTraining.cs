namespace BallisticsTraining
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            var planeCoors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rules = Console.ReadLine().Split(' ');

            var coorX = 0;
            var coorY = 0;

            for (int i = 0; i < rules.Length - 1; i += 2)
            {
                var temp = int.Parse(rules[i + 1]);

                if (rules[i] == "up")
                {
                    coorY += temp;
                }
                else if (rules[i] == "down")
                {
                    coorY -= temp;
                }
                else if (rules[i] == "left")
                {
                    coorX -= temp;
                }
                else if (rules[i] == "right")
                {
                    coorX += temp;
                }
            }

            Console.WriteLine("firing at [{0}, {1}]", coorX, coorY);

            if (coorX == planeCoors[0] && coorY == planeCoors[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
