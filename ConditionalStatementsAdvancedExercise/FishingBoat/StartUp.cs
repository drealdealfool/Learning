
namespace FishingBoat
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (fishermen <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermen > 12)
                    {
                        price = price * 0.75;
                    }
                    if (fishermen % 2 ==0)
                    {
                        price = price * 0.95;
                    }
                    break;

                case "Summer":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermen > 12)
                    {
                        price = price * 0.75;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price * 0.95;
                    }
                    break;

                case "Autumn":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermen > 12)
                    {
                        price = price * 0.75;
                    }
                    break;

                case "Winter":
                    price = 2600;
                    if (fishermen <= 6)
                    {
                        price = price * 0.90;
                    }
                    else if (7 < fishermen && fishermen <= 11)
                    {
                        price = price * 0.85;
                    }
                    else if (fishermen > 12)
                    {
                        price = price * 0.75;
                    }
                    if (fishermen % 2 == 0)
                    {
                        price = price * 0.95;
                    }
                    break;

            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
            }

        }
    }
}
