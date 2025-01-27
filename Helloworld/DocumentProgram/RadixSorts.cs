using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class RadixSorts
    {
        static void CountingSort(int[] array, int exp)
        {
            int n = array.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (array[i] / exp) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (array[i] / exp) % 10;
                output[count[digit] - 1] = array[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }
        static void RadixSort(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(array, exp);
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of elements:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            RadixSort(array);

            Console.WriteLine("Sorted array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
    }
}
