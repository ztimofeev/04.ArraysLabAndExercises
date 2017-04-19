namespace PowerPlants
{
    using System;
    using System.Linq;

    public class PowerPlants
    {
        public static void Main()
        {
            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var season = plants.Length;
            var days = 0;
            bool isAlive = true;

            while (isAlive)
            {
                for (int dayNumber = 0; dayNumber < season; dayNumber++)
                {
                    for (int i = 0; i < plants.Length; i++)
                    {
                        if (i == dayNumber & plants[i] > 0)
                        {
                            plants[i]++;
                        }

                        if (plants[i] > 0)
                        {
                            plants[i]--;
                        }

                        if (dayNumber == season - 1 && plants[i] > 0)
                        {
                            plants[i]++;
                        }

                        if (plants.Sum() == 0)
                        {
                            isAlive = false;
                        }
                    }
                    days++;

                    if (isAlive == false)
                    {
                        break;
                    }
                }
            }

            var seasons = (days - 1) / plants.Length;
            Console.WriteLine($"survived {days} days ({seasons} seasons)");
        }
    }
}
