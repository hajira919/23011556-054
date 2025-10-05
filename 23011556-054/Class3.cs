using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23011556_054
{
    internal class Class3
    {
        public static void Run()
        {
            Console.Write("Enter marks (0–100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 85) Console.WriteLine("Grade: A");
            else if (marks >= 70) Console.WriteLine("Grade: B");
            else if (marks >= 55) Console.WriteLine("Grade: C");
            else if (marks >= 40) Console.WriteLine("Grade: D");
            else Console.WriteLine("Grade: F");
        }

    }
}
