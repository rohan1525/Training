using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class StackOverflowException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a string with more than 3 characters:");
                string input = Console.ReadLine();
                ValidateInput(input);
            }
            catch (System.StackOverflowException ex)
            {
                Console.WriteLine("A StackOverflowException occurred: " + ex.Message);
            }
        }

        static void ValidateInput(string input)
        {
            if (input.Length < 3)
            {
                Console.WriteLine("Input is too short. Asking for input again...");
                ValidateInput(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Valid input received!");
            }
        }
    }
}
