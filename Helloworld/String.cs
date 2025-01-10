using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class String
    {
        static void Main(string[] args)
        {
            var firstName = "Rohan";
            var lastName = "Bhalala";

            var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myFullName);


            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);


            Console.WriteLine(formattedNames);
            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);
        }
    }
}
