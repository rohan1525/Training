using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class MatrixRowInterchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter first row to swap: ");
            int row1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second row to swap: ");
            int row2 = int.Parse(Console.ReadLine());

            if (row1 >= 0 && row1 < rows && row2 >= 0 && row2 < rows)
            {
                for (int j = 0; j < cols; j++)
                {
                    int temp = matrix[row1, j];
                    matrix[row1, j] = matrix[row2, j];
                    matrix[row2, j] = temp;
                }

                Console.WriteLine("Matrix after swapping rows:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid row indices.");
            }
        }
    }
}
