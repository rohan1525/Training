using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("Multiplication Table: " + result);

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{result} * {i} = {result * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}
