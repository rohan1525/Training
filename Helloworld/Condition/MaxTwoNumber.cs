using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Condition
{
    partial class MaxTwoNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
        }
    }
}
