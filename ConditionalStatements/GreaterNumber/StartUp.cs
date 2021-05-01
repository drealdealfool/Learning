
namespace GreaterNumber
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(numOne, numTwo));
        }
    }
}
