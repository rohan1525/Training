using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter " + n + " elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }

            Console.WriteLine("Sorted array:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
        }
    }
}
