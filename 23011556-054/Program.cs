using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== 23011556-054 Menu ===");
                Console.WriteLine("1. Even or Odd Checker");
                Console.WriteLine("2. Simple Calculator");
                Console.WriteLine("3. Grade Evaluator");
                Console.WriteLine("4. Sum of Natural Numbers");
                Console.WriteLine("5. Multiplication Table");
                Console.WriteLine("6. Factorial Calculator");
                Console.WriteLine("7. Reverse a Number");
                Console.WriteLine("8. Array - Find Max & Min");
                Console.WriteLine("9. Array - Count Even & Odd");
                Console.WriteLine("10. Array - Search Element");
                Console.WriteLine("0. Exit");
                Console.Write("Choose a program: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Class1.Run(); break;
                    case "2": Class2.Run(); break;
                    case "3": Class3.Run(); break;
                    case "4": Class4.Run(); break;
                    case "5": Class5.Run(); break;
                    case "6": Class6.Run(); break;
                    case "7": Class7.Run(); break;
                    case "8": Class8.Run(); break;
                    case "9": Class9.Run(); break;
                    case "10": Class10.Run(); break;
                    case "0": running = false; break;
                    default: Console.WriteLine("Invalid choice, try again."); break;
                }
            }


        }
    }
 }
