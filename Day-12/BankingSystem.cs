using System;

class BankAccount
{
    public double balance = 1000;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc = new BankAccount();

        acc.Deposit(500);
        acc.Withdraw(200);

        Console.WriteLine("Balance: " + acc.balance);
    }
}
