using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class SumOfEvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();

            try
            {
                int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

                int sumofeven = numbers.Where(x => x % 2 == 0).Sum();
                Console.WriteLine("Sum of Even: "+sumofeven);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
