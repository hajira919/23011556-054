using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class9
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int evenCount = 0, oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0) evenCount++;
                else oddCount++;
            }

            Console.WriteLine($"Even numbers = {evenCount}, Odd numbers = {oddCount}");
        }

    }
}
