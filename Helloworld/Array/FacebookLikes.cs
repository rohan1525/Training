using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Array
{
    public class FacebookLikes
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name: ");
                var name = Console.ReadLine();
                list.Add(name);
                if (list.Count == 1)
                {
                    Console.WriteLine(list[0] + " likes your post.");
                }
                else if (list.Count == 2)
                {
                    Console.WriteLine(list[0] + " and " + list[1] + " like your post.");
                }
                else if (list.Count == 3)
                {
                    Console.WriteLine(list[0] + ", " + list[1] + " and " + list[2] + " like your post.");
                }
                else if (list.Count > 3)
                {
                    Console.WriteLine(list[0] + ", " + list[1] + " and " + (list.Count - 2) + " others like your post.");
                }
            }
        }
    }
}
