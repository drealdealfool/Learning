
namespace PersonalTitles
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string output = "";

            switch (gender)
            {
                case "m":
                    if (age < 16)
                    {
                        output = "Master";
                    }
                    else
                    {
                        output = "Mr.";
                    }
                    break;

                case "f":
                    if (age < 16)
                    {
                        output = "Miss";
                    }
                    else
                    {
                        output = "Ms.";
                    }
                    break;

            }

            Console.WriteLine(output);

        }
    }
}
