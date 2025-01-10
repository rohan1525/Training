using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class ReverseName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            System.Array.Reverse(nameArray);
            string reversedName = new string(nameArray);
            Console.WriteLine(reversedName);
        }
    }
}
