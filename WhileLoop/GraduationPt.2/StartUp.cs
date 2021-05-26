
namespace GraduationPt._2
{
using System;
    class StartUP
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int count = 0;
            int count1 = 0;

            while (true)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    count1++;
                    if (count1 == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {count} grade");
                        break;
                    }
                }
                count++;
                sum += grade;

                if (count == 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {(sum / count):f2}");
                    break;
                }
            }

        }
    }
}
