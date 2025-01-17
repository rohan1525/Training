using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class AverageOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            try
            {
                double[] numbers2 = numbers.Select(double.Parse).ToArray();

                if(numbers2.Length == 0)
                {
                    Console.WriteLine("No Number Enter");
                    return;
                }
                double average = numbers2.Average();
                Console.WriteLine("Average Number: " +average);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Number");
            }

        }
    }
}
