using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Loops
{
    public class RandomNumberGuessing
    {
        static void Main(String[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 100);
            Console.WriteLine("Secret number is: " + secretNumber);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("You Won.");
                    break;
                }
                else
                {
                    Console.WriteLine("You Lost!");
                }
            }
        }
    }
}
