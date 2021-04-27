
namespace DepositCalculator
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double finalSum = depositedSum + termOfDeposit * ((depositedSum * interest / 100) / 12);
            Console.WriteLine(finalSum);
        }
    }
}
