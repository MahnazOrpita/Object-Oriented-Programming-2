using System;
class BankAccount
{
    private string accountNumber;
    private string accountHolderName;
    private double accountBalance;

    public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        this.accountBalance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            accountBalance += amount;
            Console.WriteLine($"{amount} deposited successfully.");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= accountBalance)
        {
            accountBalance -= amount;
            Console.WriteLine($"{amount} withdrawn successfully.");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
        }
    }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}");
        Console.WriteLine($"Account Holder's Name: {accountHolderName}");
        Console.WriteLine($"Account Balance: {accountBalance}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Account Number:");
        string accNumber = Console.ReadLine();

        Console.Write("Enter Account Holder's Name:");
        string accHolderName = Console.ReadLine();

        Console.Write("Enter Initial Balance:");
        double initialBalance = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(accNumber, accHolderName, initialBalance);

        Console.Write("Enter deposit amount:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        account.Deposit(depositAmount);

        Console.Write("Enter withdrawal amount:");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
        account.Withdraw(withdrawAmount);

        Console.Write("\nAccount Details:");
        account.DisplayAccountDetails();
    }
}
