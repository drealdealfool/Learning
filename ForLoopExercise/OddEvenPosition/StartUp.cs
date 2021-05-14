
namespace OddEvenPosition
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= count; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;

                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }

                }
                else
                {
                    oddSum += number;

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                }

            }

            if (oddSum == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }
    }
}
