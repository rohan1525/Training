using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class Arrays
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 10, 11, 12, 6, 7, 8, 9 };

            //Length
            Console.WriteLine("Length is: " + numbers.Length);

            //Indexof
            var index = System.Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);

            //Clear
            System.Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Copy
            int[] another = new int[3];
            System.Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }
        }
    }
}
