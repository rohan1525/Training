using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class NullReferenceException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                if (input.Length < 3)
                {
                    input = null;
                }

                Console.WriteLine("Third character: " + input[2]);
            }
            catch (System.NullReferenceException ex)
            {
                Console.WriteLine("Exception Caught: " + ex.Message);
            }
        }
    }
}
