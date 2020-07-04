using System;
using System.Globalization;
using AccountExeception.Entities;
using AccountExeception.Entities.Exeception;

namespace AccountExeception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data.");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: ");
                double initial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, initial, limit);
                
                Console.WriteLine();
                Console.Write("Enter amount for widtdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                
                Console.WriteLine("New balance: " + account.Balance);
            } catch(DomaninExeception e)
            {
                Console.WriteLine("Error: " + e.Message);
            } catch(FormatException e)
            {
                Console.WriteLine("Erro Format: " + e.Message);
            } catch(Exception e)
            {
                Console.WriteLine("Error(view Message): " + e.Message);
            }
        }
    }
}