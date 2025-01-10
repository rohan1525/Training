using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Rohan");
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);
        }
    }
}
