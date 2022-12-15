using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class SumOfDigit
    {
        public static void SumOfDigit1(int inputNumber)
        {
            int backupValue = inputNumber;
            int sum = 0, remainder = 0;

            while(inputNumber != 0)
            {
                remainder = inputNumber % 10;
                sum = sum + remainder;
                inputNumber = inputNumber / 10;
            }
            Console.WriteLine("Sum of {0} is {1}",backupValue,sum);
        }

    }
}
