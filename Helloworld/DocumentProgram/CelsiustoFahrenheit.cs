﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class CelsiustoFahrenheit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = ((celsius * 9) / 5) + 32;

            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            Console.ReadLine();
        }
    }
}
