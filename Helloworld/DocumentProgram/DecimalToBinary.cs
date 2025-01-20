using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());

            string binaryResult = "";

            while (decimalNumber > 0)
            {
                binaryResult = (decimalNumber % 2) + binaryResult;
                decimalNumber /= 2;
            }

            Console.WriteLine("Binary equivalent: " + binaryResult);
        }
    }
}
