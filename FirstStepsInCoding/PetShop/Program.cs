
namespace PetShop
{
using System;
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherPets = int.Parse(Console.ReadLine());
            double sum = dogs * 2.5 + otherPets * 4;
            Console.WriteLine($"{sum} lv.");
        }
    }
}
