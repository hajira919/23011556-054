using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class8
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            int max = arr[0], min = arr[0];

            foreach (int num in arr)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            Console.WriteLine($"Maximum = {max}, Minimum = {min}");
        }

    }
}
