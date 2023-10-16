using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.B_Summing_two_integers1
{
    internal class Program
    {
        public static bool sum(int a, int b)
        {
            return a == 30 || b == 30 || (a + b == 30);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of the two integers is 30");
            Console.WriteLine(sum(30, 0));
            Console.WriteLine(sum(25, 5));
            Console.WriteLine(sum(20, 30));
            Console.WriteLine(sum(20, 25));
            Console.ReadLine();
        }
    }
}
