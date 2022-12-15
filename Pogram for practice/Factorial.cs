using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class Factorial
    {
        public static void FactorialNumber(int n)
        {
            int fact = 1;
            int i;
            int temp = n;
            for (i = 1; i <= temp; i++)
            {
                fact = fact * n;
                n = (n - 1);
            }
            Console.WriteLine("The factorial {0}", fact);
        }
    }
}
