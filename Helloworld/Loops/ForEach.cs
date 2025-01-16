using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Loops
{
    public class ForEach
    {
        static void Main(string[] args)
        {
            var names = "Jane Smith";

            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (var character in names)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
