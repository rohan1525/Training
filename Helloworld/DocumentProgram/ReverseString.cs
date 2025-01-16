using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine();

            string reversedString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }
            Console.WriteLine("String in Reverse: " + reversedString);
        }
    }
}
