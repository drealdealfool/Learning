﻿
namespace NumberSequence
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }

            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");

        }
    }
}
