﻿
namespace NumbersFrom1ToNWith3Steps
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
