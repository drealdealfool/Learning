
namespace OperationsBetweenNumbers
{
using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;
            string oddOrEven = "";

            switch (symbol)
            {
                case "+":
                    result = num1 + num2;
                    if (result % 2 ==0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} + {num2} = {result} - {oddOrEven}");
                    break;

                case "-":
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} - {num2} = {result} - {oddOrEven}");
                    break;

                case "*":
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        oddOrEven = "even";
                    }
                    else
                    {
                        oddOrEven = "odd";
                    }
                    Console.WriteLine($"{num1} * {num2} = {result} - {oddOrEven}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    break;

            }
        }
    }
}
