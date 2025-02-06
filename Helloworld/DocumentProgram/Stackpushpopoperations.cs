using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class Stackpushpopoperations
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                Console.Write("Enter operation (push/pop/exit): ");
                string operation = Console.ReadLine().ToLower();

                if (operation == "push")
                {
                    Console.Write("Enter number to push: ");
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        stack.Push(number);
                        Console.WriteLine($"{number} has been pushed onto the stack.\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.\n");
                    }
                }
                else if (operation == "pop")
                {
                    if (stack.Count > 0)
                    {
                        int popped = stack.Pop();
                        Console.WriteLine($"{popped} has been popped from the stack.\n");
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty. Cannot pop.\n");
                    }
                }
                else if (operation == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please try again.\n");
                }
            }
        }
    }
}
