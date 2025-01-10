using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Loops
{
    public class Factorial
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("Number: " + factorial);
        }
    }
}
