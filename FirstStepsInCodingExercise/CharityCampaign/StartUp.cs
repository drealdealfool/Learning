
namespace CharityCampaign
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakeCost = cakes * 45;
            double waffleCost = waffles * 5.80;
            double pancakeCost = pancakes * 3.20;

            double earnings = days * cooks * (cakeCost + waffleCost + pancakeCost);
            double expenses = earnings * 1 / 8;
            double profit = earnings - expenses;

            Console.WriteLine(profit);
        }
    }
}
