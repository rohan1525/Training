using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class IdentityMatrixChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool isIdentity = IsIdentityMatrix(matrix, n);

            if (isIdentity)
            {
                Console.WriteLine("\nThe matrix is an identity matrix.");
            }
            else
            {
                Console.WriteLine("\nThe matrix is not an identity matrix.");
            }
        }

        static bool IsIdentityMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == j && matrix[i, j] != 1) || (i != j && matrix[i, j] != 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
