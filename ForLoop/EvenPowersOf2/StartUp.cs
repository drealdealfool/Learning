
namespace EvenPowersOf2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int j = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(j);

                j = j * 2 * 2;
            }

        }
    }
}
