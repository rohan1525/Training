using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class UniqueNumbersSorting
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've already entered " + number + ". Please enter a different number.");
                }
                else
                {
                    numbers.Add(number);
                }
                numbers.Sort();
                Console.WriteLine("Unique numbers entered: ");
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
