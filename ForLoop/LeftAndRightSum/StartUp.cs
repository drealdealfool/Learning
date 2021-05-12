
namespace LeftAndRightSum
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            count = count * 2;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i <= count / 2)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }

            }

            int diff = Math.Abs(sum1 - sum2);

            if (diff == 0)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }

        }
    }
}
