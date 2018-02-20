using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();
        var input = Console.ReadLine();

        while ( input != "End")
        {
            var commands = input.Split();

            switch (commands[0])
            {
                case "Create":
                    Create(int.Parse(commands[1]), accounts);
                    break;
                case "Deposit":
                    Deposit(int.Parse(commands[1]), decimal.Parse(commands[2]), accounts);
                    break;
                case "Withdraw":
                    Withdraw(int.Parse(commands[1]), decimal.Parse(commands[2]), accounts);
                    break;
                case "Print":
                    Print(int.Parse(commands[1]), accounts);
                    break;
                default:
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static void Create(int id, Dictionary<int, BankAccount> accounts)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }
    private static void Deposit(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(amount);
        }
    }
    private static void Withdraw(int id, decimal amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(amount);
        }
    }
    private static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id].ToString());
        }
    }
}