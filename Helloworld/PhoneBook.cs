using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class PhoneBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (true)
            {
                Console.Write("Enter contact name: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                    break;

                if (name.Length < 3)
                {
                    Console.WriteLine("Error: Name is too short. Must be at least 3 characters.");
                    continue;
                }

                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();

                if (phoneNumber.Length < 7)
                {
                    Console.WriteLine("Error: Phone number is too short. Must be at least 7 digits.");
                    continue;
                }

                contacts[name] = phoneNumber;
                Console.WriteLine("Contact saved successfully!\n");
            }

            Console.WriteLine("\nPhone Book:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
            }
        }
    }
}
