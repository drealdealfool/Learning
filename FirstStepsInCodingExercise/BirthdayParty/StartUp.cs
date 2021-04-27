
namespace BirthdayParty
{
using System;
    class StartUP
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent / 5;
            double drinks = cake * 55 / 100;
            double animator = rent / 3;
            double finalCost = rent + cake + drinks + animator;
            Console.WriteLine(finalCost);
        }
    }
}
