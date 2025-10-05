using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class7
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }

            Console.WriteLine($"Reversed number = {reverse}");
        }

    }
}
