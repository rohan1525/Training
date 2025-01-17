using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class WordCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            int count = words.Length;
            Console.WriteLine("Word Count: " + count);
        }
    }
}
