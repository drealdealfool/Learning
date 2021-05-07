
namespace NumberInRange
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string result = "";

            if (number >= -100 && number <= 100 && number != 0)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }

            Console.WriteLine(result);

        }
    }
}
