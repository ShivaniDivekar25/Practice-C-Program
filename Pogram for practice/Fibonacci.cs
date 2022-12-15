using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class Fibonacci
    {
        static int p1 = 0, p2 = 1, p3;
        public static void FibonacciNumber(int count)
        {
            Console.Write(p1 + " " + p2);
            for (int i = 1; i < count; i++)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
            }
        }   
    }
}
