
namespace Cinema
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double ticket = 0;

            switch (type)
            {
                case "Premiere":
                    ticket = 12.00;
                    break;

                case "Normal":
                    ticket = 7.50;
                    break;

                case "Discount":
                    ticket = 5.00;
                    break;

            }

            double income = ticket * rows * columns;

            Console.WriteLine($"{income:f2} leva");

        }
    }
}
