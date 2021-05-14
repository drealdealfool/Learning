
namespace Salary
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string tab = Console.ReadLine();

                switch (tab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;

                    case "Instagram":
                        salary -= 100;
                        break;

                    case "Reddit":
                        salary -= 50;
                        break;

                }

                if (salary <= 0)
                {
                    break;
                }

            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }

        }
    }
}
