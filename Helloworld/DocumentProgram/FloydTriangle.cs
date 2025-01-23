using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class FloydTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
