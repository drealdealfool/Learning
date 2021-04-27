
namespace ConsoleConverter
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double courseDollars = 1.79549;
            double dollars = double.Parse(Console.ReadLine());
            double levaConverted = dollars * courseDollars;
            Console.WriteLine(Math.Round(levaConverted, 2));
        }
    }
}
