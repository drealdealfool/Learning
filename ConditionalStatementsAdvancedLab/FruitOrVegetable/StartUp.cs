
namespace FruitOrVegetable
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string output = "";

            switch (productName)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    output = "fruit";
                    break;

                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    output = "vegetable";
                    break;

                default:
                    output = "unknown";
                    break;

            }

            Console.WriteLine(output);

        }
    }
}
