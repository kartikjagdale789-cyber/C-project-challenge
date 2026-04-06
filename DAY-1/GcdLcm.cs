using System;

class GcdLcm
{
    static void Main()
    {
        int a = 12, b = 18, gcd = 1;

        for (int i = 1; i <= a && i <= b; i++)
        {
            if (a % i == 0 && b % i == 0)
                gcd = i;
        }

        int lcm = (a * b) / gcd;

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }
}