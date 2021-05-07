
namespace WorkingHours
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int workingHours = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            string output = "";

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (workingHours >= 10 && workingHours <= 18)
                    {
                        output = "open";
                    }
                    else
                    {
                        output = "closed";
                    }
                    break;

                case "Sunday":
                    output = "closed";
                    break;

            }

            Console.WriteLine(output);

        }
    }
}
