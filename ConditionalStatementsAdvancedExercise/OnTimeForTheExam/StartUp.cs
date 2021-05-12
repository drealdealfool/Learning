
namespace OnTimeForTheExam
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHours = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int examTime = examHours * 60 + examMinutes;
            int studentTime = studentHours * 60 + studentMinutes;
            int timeDifference = studentTime - examTime;

            if (timeDifference < -30)
            {
                Console.WriteLine("Early");
            }
            else if (timeDifference <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (timeDifference != 0)
            {
                int hours = Math.Abs(timeDifference / 60);
                int minutes = Math.Abs(timeDifference % 60);

                if (hours > 0)
                {
                    Console.Write($"{hours}:{minutes:d2} hours");
                }
                else
                {
                    Console.Write($"{minutes} minutes");
                }

                if (timeDifference > 0)
                {
                    Console.WriteLine(" after the start");
                }
                else
                {
                    Console.WriteLine(" before the start");
                }
            }

        }
    }
}
