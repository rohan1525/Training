using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class IndexOutOfRangeException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number for the array size:");
                int size = int.Parse(Console.ReadLine());

                int[] numbers = new int[size];

                Console.WriteLine("Enter a number to store at index 5:");
                int number = int.Parse(Console.ReadLine());

                numbers[5] = number;

                Console.WriteLine("Number stored successfully at index 5.");
            }
            catch (System.IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Invalid input: {ex.Message}");
            }
        }
    }
}
