using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PassByReferenceDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine("Value Before : {0}", val);
            square(ref val);
            Console.WriteLine("Value After : {0}", val);
            Console.Read();
        }

        static void square(ref int refParam)
        {
            refParam *= refParam;
        }
    }
}
