using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class MultilevelInheritance
    {
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        class Mammal : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("The mammal makes a sound.");
            }
        }

        class Dog : Mammal
        {
            public override void Speak()
            {
                Console.WriteLine("The dog barks: Woof Woof!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose an animal type: 1. Animal  2. Mammal  3. Dog");
                Console.Write("Enter your choice (1-3): ");
                int choice = int.Parse(Console.ReadLine());

                Animal selectedAnimal;

                switch (choice)
                {
                    case 1:
                        selectedAnimal = new Animal();
                        break;
                    case 2:
                        selectedAnimal = new Mammal();
                        break;
                    case 3:
                        selectedAnimal = new Dog();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Defaulting to generic animal.");
                        selectedAnimal = new Animal();
                        break;
                }
                selectedAnimal.Speak();
            }
        }
    }
}
