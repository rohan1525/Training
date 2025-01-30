using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class SumDiagonalElementsMatrix
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
                    Console.Write($"Enter element at [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe matrix is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int diagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                diagonalSum += matrix[i, i];
                if (i != n - i - 1) 
                    diagonalSum += matrix[i, n - i - 1];
            }
            Console.WriteLine($"\nThe sum of diagonal elements is: {diagonalSum}");
        }
    }
}
