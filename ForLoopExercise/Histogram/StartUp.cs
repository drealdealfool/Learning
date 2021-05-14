
namespace Histogram
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
            double count4 = 0;
            double count5 = 0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    count1++;
                }
                else if (number < 400)
                {
                    count2++;
                }
                else if (number < 600)
                {
                    count3++;
                }
                else if (number < 800)
                {
                    count4++;
                }
                else
                {
                    count5++;
                }

            }

            if (count1 > 0)
            {
                Console.WriteLine($"{(count1 / (double)count * 100):f2}%");
            }
            else
            {
                Console.WriteLine("0.00%");
            }

            if (count2 > 0)
            {
                Console.WriteLine($"{(count2 / (double)count * 100):f2}%");
            }
            else
            {
                Console.WriteLine("0.00%");
            }

            if (count3 > 0)
            {
                Console.WriteLine($"{(count3 / (double)count * 100):f2}%");
            }
            else
            {
                Console.WriteLine("0.00%");
            }

            if (count4 > 0)
            {
                Console.WriteLine($"{(count4 / (double)count * 100):f2}%");
            }
            else
            {
                Console.WriteLine("0.00%");
            }

            if (count5 > 0)
            {
                Console.WriteLine($"{(count5 / (double)count * 100):f2}%");
            }
            else
            {
                Console.WriteLine("0.00%");
            }

        }
    }
}
