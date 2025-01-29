using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class UpperTriangularMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Upper Triangular Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > j)
                        Console.Write("0 ");
                    else
                        Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
