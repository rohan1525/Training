using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Loops
{
    public class Continuouslyasknumberorok
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or OK to exit");
                string input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += int.Parse(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }
    }
}
