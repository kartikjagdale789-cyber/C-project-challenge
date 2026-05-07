using System;

class CurrencyConverter {
    static void Main() {
        double inr = 1000;
        double usd = inr / 83.0;

        Console.WriteLine("$" + usd);
    }
}