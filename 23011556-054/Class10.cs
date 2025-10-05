using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class10
    {
        public static void Run()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            foreach (int num in arr)
            {
                if (num == search)
                {
                    found = true;
                    break;
                }
            }

            if (found) Console.WriteLine("Element found in array.");
            else Console.WriteLine("Element not found in array.");
        }

    }
}
