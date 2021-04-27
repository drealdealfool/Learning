
namespace YardGreening
{
using System;
    class Program
    {
        static void Main(string[] args)
        {
            double acreage = double.Parse(Console.ReadLine());
            double price = 7.61;
            double finalPrice = acreage * price * 0.82;
            double discount = acreage * price - finalPrice;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
