using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogram_for_practice
{
    internal class TemperatureConverter
    {
        public double CelciusTofahrenheit()
        {
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenhiet = (celcius * 9 / 5) + 3;
            return fahrenhiet;
        }

        public double FahrenhietToCelcius()
        {
            double fahrenhiet = Convert.ToDouble(Console.ReadLine());
            double celcius = (fahrenhiet - 32) * 5 / 9;
            return celcius;
        }
    }
}
