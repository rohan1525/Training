using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class ATMTransaction
    {
        static void Main(string[] args)
        {
            int balance = 5000;
            int amount;
            int choice;

            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Your current balance is: $" + balance);
                    break;

                case 2:
                    Console.Write("Enter deposit amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine("Deposit successful! New balance: $" + balance);
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    if (amount > balance)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine("Withdrawal successful! New balance: $" + balance);
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
