using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class Sumofdigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int sum = CalculateSumofDigit(Math.Abs(number));
                Console.WriteLine("The Sum of Digit is: " + sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        static int CalculateSumofDigit(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

    }
}
