using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (Isprime(number))
                {
                    Console.WriteLine("Number is prime");
                }
                else
                {
                    Console.WriteLine("Number is not Prime");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static bool Isprime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
