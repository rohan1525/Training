using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Enter the number of columns {i + 1}:");
                int columns = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Enter value for element [{i},{j}]:");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
