
namespace Volleyball
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string leapOrNot = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double saturdays = (48 - (double)weekends) * 3 / 4;
            double holidaysActual = (double)holidays * 2 / 3;

            double volleyballPlayed = saturdays + holidaysActual + weekends;

            if (leapOrNot == "normal")
            {
                Console.WriteLine(Math.Floor(volleyballPlayed));
            }
            else if (leapOrNot == "leap")
            {
                Console.WriteLine(Math.Floor(volleyballPlayed * 1.15));
            }

        }
    }
}
