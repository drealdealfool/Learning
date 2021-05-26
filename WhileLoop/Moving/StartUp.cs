
namespace Moving
{
using System;
    class STartUp
    {
        static void Main(string[] args)
        {
            int box = 1;

            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int space = width * length * height;

            while (space > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{space} Cubic meters left.");
                    break;
                }
                int boxes = int.Parse(input);

                space -= boxes;
            }

            if (space < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
            }

        }
    }
}
