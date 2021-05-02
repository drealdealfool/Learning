
namespace WorldSwimmingRecord
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double pace = double.Parse(Console.ReadLine());

            double slow = Math.Floor(distance / 15) * 12.5;
            double timeIvan = pace * distance + slow;

            if (timeIvan < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:f2} seconds.");
            }
            if (timeIvan >= record)
            {
                Console.WriteLine($"No, he failed! He was {(timeIvan - record):f2} seconds slower.");
            }

        }
    }
}
