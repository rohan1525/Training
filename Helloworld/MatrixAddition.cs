using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class MatrixAddition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];

            Console.WriteLine("Enter elements of first matrix:");
            InputMatrix(matrix1, rows, cols);

            Console.WriteLine("Enter elements of second matrix:");
            InputMatrix(matrix2, rows, cols);

            AddMatrices(matrix1, matrix2, sumMatrix, rows, cols);

            Console.WriteLine("Sum of matrices:");
            PrintMatrix(sumMatrix, rows, cols);
        }

        static void InputMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void AddMatrices(int[,] mat1, int[,] mat2, int[,] sum, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
        }
        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
