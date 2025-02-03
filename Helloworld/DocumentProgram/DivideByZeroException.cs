using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class DivideByZeroException
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a numerator: ");
                string numeratorInput = Console.ReadLine();

                if (numeratorInput.Length < 1)
                {
                    Console.WriteLine("Input is too short, please provide a valid number.");
                    return;
                }

                int numerator = Convert.ToInt32(numeratorInput);

                Console.Write("Enter a denominator: ");
                string denominatorInput = Console.ReadLine();

                if (denominatorInput.Length < 1)
                {
                    Console.WriteLine("Input is too short, please provide a valid number.");
                    return;
                }

                int denominator = Convert.ToInt32(denominatorInput);

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Error: Attempted to divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter valid integers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
