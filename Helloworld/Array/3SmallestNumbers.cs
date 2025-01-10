using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class _3SmallestNumbers
    {
        static void Main(String[] args)
        {
            while (true)
            {
                Console.Write("Enter a numbers: ");
                string input = Console.ReadLine();

                var numbers = input.Split(',').Select(n => int.Parse(n.Trim())).ToList();

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List");
                }
                else
                {
                    var smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
                    Console.WriteLine("3 smallest numbers are: " + string.Join(", ", smallestNumbers));
                    break;
                }
            }
        }
    }
}
