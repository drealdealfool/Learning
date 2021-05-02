
namespace GodzillaVs.Kong
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            filmBudget = filmBudget * 0.90;

            if (statists > 150)
            {
                costumePrice = costumePrice * 0.90;
            }

            double costumeBudget = costumePrice * statists;

            if (filmBudget < costumeBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(costumeBudget - filmBudget):f2} leva more.");
            }
            
            if (filmBudget >= costumeBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(filmBudget - costumeBudget):f2} leva left.");
            }

        }
    }
}
