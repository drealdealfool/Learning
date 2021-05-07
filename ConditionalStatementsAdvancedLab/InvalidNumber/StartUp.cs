
namespace InvalidNumber
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string output = "";

            if (number >= 100 && number <= 200 || number == 0)
            {

            }
            else
            {
                output = "invalid";
            }

            Console.WriteLine(output);

        }
    }
}
