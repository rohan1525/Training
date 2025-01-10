using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Condition
{
    public class ImageHeightWidth
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Image Height");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Image Width");
            var width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Image is Portrait");
            }
            else if (height < width)
            {
                Console.WriteLine("Image is Landscape");
            }
            else
            {
                Console.WriteLine("Image is Square");
            }
        }
    }
}
