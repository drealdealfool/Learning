
namespace MetricConverter
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string enterValue = Console.ReadLine();
            string exitValue = Console.ReadLine();

            if (enterValue == "mm" && exitValue == "m")
            {
                number = number / 1000;
            }
            if (enterValue == "mm" && exitValue == "cm")
            {
                number = number / 10;
            }
            if (enterValue == "cm" && exitValue == "m")
            {
                number = number / 100;
            }
            if (enterValue == "cm" && exitValue == "mm")
            {
                number = number * 10;
            }
            if (enterValue == "m" && exitValue == "mm")
            {
                number = number * 1000;
            }
            if (enterValue == "m" && exitValue == "cm")
            {
                number = number  * 100;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}
