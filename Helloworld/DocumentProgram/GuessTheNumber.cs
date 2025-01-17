using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class GuessTheNumber
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            int guess = 0;
            int attempts = 0;

            while (guess != number)
            {
                Console.WriteLine("Enter a Number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < number)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have guessed the number:", +attempts);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }
        }
    }
}
