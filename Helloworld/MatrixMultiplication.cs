using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class MatrixMultiplication
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows for first matrix: ");
            int rows1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns for first matrix (rows for second matrix): ");
            int cols1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns for second matrix: ");
            int cols2 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[cols1, cols2];
            int[,] result = new int[rows1, cols2];

            Console.WriteLine("\nEnter elements of first matrix:");
            for (int i = 0; i < rows1; i++)
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("\nEnter elements of second matrix:");
            for (int i = 0; i < cols1; i++)
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }

            for (int i = 0; i < rows1; i++)
                for (int j = 0; j < cols2; j++)
                    for (int k = 0; k < cols1; k++)
                        result[i, j] += matrix1[i, k] * matrix2[k, j];

            Console.WriteLine("\nResultant Matrix:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                    Console.Write(result[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
