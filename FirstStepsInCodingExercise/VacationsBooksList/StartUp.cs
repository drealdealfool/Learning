
namespace VacationsBooksList
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double numberOfPages = double.Parse(Console.ReadLine());
            double pagesRead = double.Parse(Console.ReadLine());
            double numberOfDays = double.Parse(Console.ReadLine());
            double hoursPerDay = (numberOfPages / numberOfDays / pagesRead);
            Console.WriteLine(hoursPerDay);
        }
    }
}
