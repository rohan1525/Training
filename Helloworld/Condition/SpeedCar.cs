using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Condition
{
    public class SpeedCar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car:");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var demeritPoints = (speed - speedLimit) / 5;
                Console.WriteLine($"Demerit points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
