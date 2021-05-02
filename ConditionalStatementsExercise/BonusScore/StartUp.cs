
namespace BonusScore
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;
            
            if (number <= 100)
            {
                bonus += 5;
            }
            if (number > 100 && number <= 1000)
            {
                bonus += number / 5;
            }
            if (number > 1000)
            {
                bonus += number / 10;
            }

            if (number % 2 ==0)
            {
                bonus += 1;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
