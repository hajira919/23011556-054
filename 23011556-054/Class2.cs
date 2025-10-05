using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class2
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '+': Console.WriteLine($"Result = {num1 + num2}"); break;
                case '-': Console.WriteLine($"Result = {num1 - num2}"); break;
                case '*': Console.WriteLine($"Result = {num1 * num2}"); break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Result = {num1 / num2}");
                    else
                        Console.WriteLine("Cannot divide by zero!");
                    break;
                default: Console.WriteLine("Invalid operator!"); break;
            }
        }

    }
}
