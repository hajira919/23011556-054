using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class4
    {
        public static void Run()
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine($"Sum = {sum}");
        }

    }
}
