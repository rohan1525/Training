using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class InsertionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            insertsort(arr, n);

            Console.WriteLine("The Sorted Array is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void insertsort(int[] data, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int item = data[i];
                int j = i - 1;
                while (j >= 0 && data[j] > item)
                {
                    data[j + 1] = data[j];  
                    j--;
                }
                data[j + 1] = item;
            }
        }
    }
}
