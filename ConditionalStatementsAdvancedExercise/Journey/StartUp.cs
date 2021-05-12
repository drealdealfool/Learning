
namespace Journey
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = budget * 0.30;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    cost = budget * 0.70;
                    type = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    cost = budget * 0.40;
                    type = "Camp";
                }
                else if (season == "winter")
                {
                    cost = budget * 0.80;
                    type = "Hotel";
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                cost = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {cost:f2}");

        }
    }
}
