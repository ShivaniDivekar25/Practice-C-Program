using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class FactorialTable
    {
        public static void FactorialTable1(int upperlimit)
        {
            for (int i = 1; i <= upperlimit; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                }
                Console.WriteLine("{0}! is {1}", i, fact);
            }
        }
    }
}
