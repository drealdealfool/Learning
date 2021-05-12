
namespace NewHouse
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            double totalCost = 0;

            switch (type)
            {
                case "Roses":
                    price = 5.00;
                    totalCost = price * count;
                    if (count > 80)
                    {
                        totalCost = totalCost * 0.90;
                    }
                    break;

                case "Dahlias":
                    price = 3.80;
                    totalCost = price * count;
                    if (count > 90)
                    {
                        totalCost = totalCost * 0.85;
                    }
                    break;

                case "Tulips":
                    price = 2.80;
                    totalCost = price * count;
                    if (count > 80)
                    {
                        totalCost = totalCost * 0.85;
                    }
                    break;

                case "Narcissus":
                    price = 3.00;
                    totalCost = price * count;
                    if (count < 120)
                    {
                        totalCost = totalCost * 1.15;
                    }
                    break;

                case "Gladiolus":
                    price = 2.50;
                    totalCost = price * count;
                    if (count < 80)
                    {
                        totalCost = totalCost * 1.20;
                    }
                    break;

            }

            if (budget >= totalCost)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {(budget - totalCost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalCost - budget):f2} leva more.");
            }

        }
    }
}
