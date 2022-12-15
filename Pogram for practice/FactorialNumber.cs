using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class Factorial1
    {
        static int fact = 1;
        public static int Factorialcalculation(int number)
        {
            if (number > 0)
            {
                fact = number * Factorialcalculation(number - 1);
            }
            return fact;
        }
    }
}
