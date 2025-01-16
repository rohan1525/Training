using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helloworld;
using Helloworld.Math;

namespace Helloworld
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.FirstName = "Rohan";
        person.LastName = "Bhalala";
        person.Introduce();

        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);
    }
}
