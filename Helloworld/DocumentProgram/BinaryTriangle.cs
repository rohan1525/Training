using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class BinaryTriangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int lastInt = 0;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
