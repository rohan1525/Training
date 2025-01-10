using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Loops
{
    public class MaximumSeriesNumber
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number of series: ");
            string input = Console.ReadLine();

            int[] numbers = input.Split(',').Select(int.Parse).ToArray();
            int max = numbers.Max();
            Console.WriteLine("Maximum number is: " + max);
        }
    }
}
