using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class QuickSorts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int[] array = Array.ConvertAll(numbers, int.Parse);

            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(arr, low, high);

                QuickSort(arr, low, pivot - 1);
                QuickSort(arr, pivot + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }
    }
}
