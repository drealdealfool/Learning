
namespace CleverLily
{
using System;
    class STartUp
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            int toyCount = 0;
            int savingsCashDummy = 0;
            int savingsCash = 0;

            for (int i = 0; i < age; i++)
            {
                if (i % 2 == 1)
                {
                    savingsCashDummy += 10;
                    savingsCash += savingsCashDummy;
                    savingsCash -= 1;
                }
                else
                {
                    toyCount++;
                }
                
            }

            double toysCash = toysPrice * toyCount;
            double cash = toysCash + savingsCash;

            if (cash >= washingMachine)
            {
                Console.WriteLine($"Yes! {(cash - washingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachine - cash):f2}");
            }
            
        }
    }
}
