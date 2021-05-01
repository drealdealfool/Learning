
namespace AreaOfFigures
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a * Math.PI);
            }
            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b / 2);
            }
        }
    }
}
