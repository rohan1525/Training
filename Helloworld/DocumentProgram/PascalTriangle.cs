using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PascalTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int spacing = 6;

            int[,] data = new int[height, height];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write("".PadRight(spacing / 2));
                }

                for (int k = 0; k <= i; k++)
                {
                    if (k == 0 || k == i)
                    {
                        data[i, k] = 1;
                    }
                    else
                    {
                        data[i, k] = data[i - 1, k] + data[i - 1, k - 1];
                    }
                    Console.Write(data[i, k].ToString().PadRight(spacing));
                }
                Console.WriteLine();
            }
        }
    }
}
