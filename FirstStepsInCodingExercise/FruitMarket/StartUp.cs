
namespace FruitMarket
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double raspberries = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberryPrice / 2;
            double orangePrice = raspberryPrice * 3 / 5;
            double bananaPrice = raspberryPrice / 5;

            double strawberryCost = strawberryPrice * strawberries;
            double raspberryCost = raspberryPrice * raspberries;
            double orangeCost = orangePrice * oranges;
            double bananaCost = bananaPrice * bananas;

            double sum = strawberryCost + raspberryCost + orangeCost + bananaCost;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
