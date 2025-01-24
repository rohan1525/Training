using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PassByValueDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Original number: {number}");

            ModifyNumber(number);
            Console.WriteLine($"Number after modification: {number}");
        }

        public static void ModifyNumber(int num)
        {
            num = 100;
            Console.WriteLine($"Modified number inside method: {num}");
        }
    }
}
