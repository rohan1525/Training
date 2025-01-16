using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Condition
{
    public class DiplayNumer1to10
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number between 1 to 10");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Enter is InValid");
                }
                else
                {
                    Console.WriteLine("Enter is Valid");
                }
            }
        }
    }
}
