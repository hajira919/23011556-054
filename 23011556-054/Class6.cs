using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class6
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long fact = 1;

            int i = 1;
            while (i <= num)
            {
                fact *= i;
                i++;
            }

            Console.WriteLine($"Factorial = {fact}");
        }

    }
}
