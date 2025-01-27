using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class SmallestElementMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int smallest = int.MaxValue; 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at position ({i},{j}): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < smallest)
                    {
                        smallest = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"The smallest element in the matrix is: {smallest}");
        }
    }
}
