
namespace CinemaTicket
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int output = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                    output = 12;
                    break;

                case "Tuesday":
                    output = 12;
                    break;

                case "Wednesday":
                    output = 14;
                    break;

                case "Thursday":
                    output = 14;
                    break;

                case "Friday":
                    output = 12;
                    break;

                case "Saturday":
                    output = 16;
                    break;

                case "Sunday":
                    output = 16;
                    break;

            }

            Console.WriteLine(output);

        }
    }
}
