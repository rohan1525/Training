using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class UserAuthentication
    {
        static void Main(string[] args)
        {
            char[] password = new char[10];
            char[] username = new char[10];
            char ch;
            int i;

            Console.WriteLine("Enter User name < 3 characters > : ");
            for (int x = 0; x < 3; x++)
            {
                username[x] = Convert.ToChar(Console.Read());
            }

            Console.Write("Enter the password < any 8 characters>: ");
            for (i = 0; i < 8; i++)
            {
                ch = Convert.ToChar(Console.Read());
                password[i] = ch;
                ch = '*';
                Console.WriteLine("{0}", ch);
            }

            Console.WriteLine("\n Your Password is :");
            for (i = 0; i < 8; i++)
            {
                Console.Write("{0}", password[i]);
            }
        }
    }
}
