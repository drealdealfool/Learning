namespace MyFirstCodingProgram
{
using System;
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());
            int timePerProject = 3 * projectCount;

            Console.WriteLine($"The architect {architectName} will need {timePerProject} hours to complete {projectCount} project/s.");
        }
    }
}
