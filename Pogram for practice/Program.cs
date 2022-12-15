using System.Drawing;

namespace Pogram_for_practice
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Console.WriteLine("Please choose any one program from below options.");
            Console.WriteLine("1:TemperatureConverter\n2:Fibonacci\n3Factorial\n4:FactorialTable\n5:SumOfDigit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    //program for Temperature Converter
                    TemperatureConverter temp = new TemperatureConverter();
                    Console.WriteLine("Please enter the celcius temp:");
                    ////string value1 = Console.ReadLine();
                    double fahrenhiet = temp.CelciusTofahrenheit();
                    Console.WriteLine("The value of {0} celcius is fahrenhiet",fahrenhiet);

                    TemperatureConverter temp1 = new TemperatureConverter();
                    Console.WriteLine("Please enter the fahrenhiet temp:");
                    ////string value2 = Console.ReadLine();
                    double celcius = temp.FahrenhietToCelcius();
                    Console.WriteLine("The value of {0} fahrenhiet is celcius",celcius);
                    break;
                case 2:
                    //Program for fibonacci
                    Console.WriteLine("Please enter input value");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Fibonacci.FibonacciNumber(count);
                    break;
                case 3:
                    //Program for factorial number
                    Console.WriteLine("Please eneter input value");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Factorial.FactorialNumber(n);
                    break;
                case 4:
                    //Program for factorial table 
                    Console.WriteLine("Please provite upper limit");
                    int upperlimit = Convert.ToInt32(Console.ReadLine());
                    FactorialTable.FactorialTable1(upperlimit);
                    break;
                case 5:
                    //Program for sum of digit
                    Console.WriteLine("Please provide input number");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());
                    SumOfDigit.SumOfDigit1(inputNumber);
                    break;
                default:
                    Console.WriteLine("Please choose number within given options");
                    break;
            }
        }
    }
}