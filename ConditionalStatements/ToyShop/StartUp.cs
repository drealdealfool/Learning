
namespace ToyShop
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double excursionCost = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int toyTrucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double talkingDollPrice = 3;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.20;
            double toyTruckPrice = 2;

            double sum = puzzlePrice * puzzles + talkingDollPrice * talkingDolls + teddyBearPrice * teddyBears + minionPrice * minions + toyTruckPrice * toyTrucks;
            int sumToys = puzzles + talkingDolls + teddyBears + minions + toyTrucks;

            if (sumToys >= 50)
            {
                sum = sum * 0.75;
            }

            sum = sum * 0.90;

            if (sum >= excursionCost)
            {
                Console.WriteLine($"Yes! {(sum - excursionCost):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(excursionCost - sum):f2} lv needed.");
            }
        }
    }
}
