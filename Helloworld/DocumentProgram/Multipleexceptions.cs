using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class Multipleexceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                if (input.Length < 3)
                {
                    throw new ArgumentException("Input is too short. Please enter 3 characters.");
                }

                int number = int.Parse(input);
                Console.WriteLine($"You entered: {number}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"ArgumentException: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
            }
        }
    }
}
