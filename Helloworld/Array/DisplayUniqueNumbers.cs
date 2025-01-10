using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class DisplayUniqueNumbers
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                int number = int.Parse(input);
                uniqueNumbers.Add(number);
            }
            Console.WriteLine("Unique numbers: " + string.Join(", ", uniqueNumbers));
        }
    }
}
