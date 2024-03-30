using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                        bank.CreateAccount(name);
                        break;

                    case 2:
                        Console.Write("Enter account number: ");
                        int accountNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter deposit amount: ");
                        double depositAmount = double.Parse(Console.ReadLine());
                        bank.Deposit(accountNumber, depositAmount);
                        break;

                    case 3:
                        Console.Write("Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawalAmount = double.Parse(Console.ReadLine());
                        bank.Withdraw(accountNumber, withdrawalAmount);
                        break;

                    case 4:
                        Console.Write("Enter account number: ");
                        accountNumber = int.Parse(Console.ReadLine());
                        bank.CheckBalance(accountNumber);
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    class Bank
    {
        private Dictionary accounts = new Dictionary();

        public void CreateAccount(string name)
        {
            Random random = new Random();
            int accountNumber = random.Next(1000, 10000);
            accounts.Add(accountNumber, 0);
            Console.WriteLine($"Account created successfully. Account Number: {accountNumber}");
        }

        public void Deposit(int accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber] += amount;
                Console.WriteLine($"Deposit successful. New balance: {accounts[accountNumber]}");
            }
            else
            {
                Console.WriteLine("Account not found. Please try again.");
            }
        }

        public void Withdraw(int accountNumber, double amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                if (accounts[accountNumber] >= amount)
                {
                    accounts[accountNumber] -= amount;
                    Console.WriteLine($"Withdrawal successful. New balance: {accounts[accountNumber]}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Account not found. Please try again.");
            }
        }

        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine($"Account Balance: {accounts[accountNumber]}");
            }
            else
            {
                Console.WriteLine("Account not found. Please try again.");
            }
        }
