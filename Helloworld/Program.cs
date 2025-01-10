using System; // system is a namespace in .NET framework and basic utility classes and primitive types there.
using System.Collections.Generic; // use List, Collection etc..
using System.Linq; // use to work with data.
using System.Text; // use to work with text codeing stuff likw that. 
using System.Threading.Tasks; // use to multi threading application.

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World");
                Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
                Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

                string str = "false";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

                var a = 2;
                var c = 4;
                var d = 6;

                Console.WriteLine(a + c * d);
                Console.WriteLine((a + c) * d);
                Console.WriteLine(c > a);
                Console.WriteLine(a != c);
                Console.WriteLine(!(a != c));
                Console.WriteLine(d > c && d > a);
                Console.WriteLine(d > c || d > a);
            }
            catch (Exception)
            {
                Console.WriteLine("Number could not be convert");
            }
        }
    }
}
