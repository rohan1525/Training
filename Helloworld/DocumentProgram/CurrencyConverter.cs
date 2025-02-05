using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.DocumentProgram
{
    public class CurrencyConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency Converter (USD to Others)");
            Console.Write("Enter amount in USD: ");
            double usd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose currency to convert to:");
            Console.WriteLine("1. EUR (Euro)");
            Console.WriteLine("2. GBP (British Pound)");
            Console.WriteLine("3. INR (Indian Rupee)");
            Console.Write("Enter choice (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double convertedAmount = 0;
            string currency = "";

            switch (choice)
            {
                case 1:
                    convertedAmount = usd * 0.92;
                    currency = "EUR";
                    break;
                case 2:
                    convertedAmount = usd * 0.78;
                    currency = "GBP";
                    break;
                case 3:
                    convertedAmount = usd * 83.10;
                    currency = "INR";
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please restart the program.");
                    return;
            }

            Console.WriteLine($"Converted Amount: {convertedAmount} {currency}");
        }
    }
}
