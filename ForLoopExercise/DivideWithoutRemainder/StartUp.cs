
namespace DivideWithoutRemainder
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }
                if (number % 3 == 0)
                {
                    count2++;
                }
                if (number % 4 == 0)
                {
                    count3++;
                }

            }

            if (count1 == 0)
            {
                Console.WriteLine("0.00%");
            }
            else
            {
                Console.WriteLine($"{(count1 / (double)count * 100):f2}%");
            }

            if (count2 == 0)
            {
                Console.WriteLine("0.00%");
            }
            else
            {
                Console.WriteLine($"{(count2 / (double)count * 100):f2}%");
            }

            if (count3 == 0)
            {
                Console.WriteLine("0.00%");
            }
            else
            {
                Console.WriteLine($"{(count3 / (double)count * 100):f2}%");
            }

        }
    }
}
