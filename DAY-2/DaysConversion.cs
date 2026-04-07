using System;

class DaysConversion
{
    static void Main()
    {
        Console.Write("Enter days: ");
        int days = int.Parse(Console.ReadLine());

        int years = days / 365;
        days %= 365;

        int months = days / 30;
        days %= 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);
    }
}