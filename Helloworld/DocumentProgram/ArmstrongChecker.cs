using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class ArmstrongChecker
    {
        static void Main(string[] args)
        {
            int number, sum = 0, originalNumber;

            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());

            originalNumber = number;

            int n = 0;
            int temp = number;
            while (temp != 0)
            {
                n++;
                temp /= 10;
            }

            temp = number;
            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, n);
                temp /= 10;
            }

            if (originalNumber == sum)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
    }
}
