﻿
namespace ReadText
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }

                Console.WriteLine(input);

            }
        }
    }
}
