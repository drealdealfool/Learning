
namespace FishTank
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double length = int.Parse(Console.ReadLine());
            double width = int.Parse(Console.ReadLine());
            double height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double capacity = length * width * height / 1000;
            double realCapacity = capacity - capacity * percentage / 100;

            Console.WriteLine(realCapacity);
        }
    }
}
