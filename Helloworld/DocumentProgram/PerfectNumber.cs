using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PerfectNumber
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("enter the num:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    sum = sum + i;
            }
            if (sum == n)
            {
                Console.WriteLine("number is perfect");
            }
            else
            {
                Console.WriteLine("not perfect");
            }
        }
    }
}
