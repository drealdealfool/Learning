
namespace Password
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string passwordAttempt = Console.ReadLine();

                if (passwordAttempt == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}
