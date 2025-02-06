using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class CastlePattern
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your castle name: ");
            string castleName = Console.ReadLine();

            if (castleName.Length < 3)
            {
                Console.WriteLine("User input too short.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("      ***         ***");
            Console.WriteLine("     *  **_______*  **");
            Console.WriteLine("    *                **");

            Console.WriteLine("   *   {0,-20}   **", castleName);
            Console.WriteLine("  *____________________**");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
