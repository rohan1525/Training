using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class FahrenheitToCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: " + celsius);
        }
    }
}
