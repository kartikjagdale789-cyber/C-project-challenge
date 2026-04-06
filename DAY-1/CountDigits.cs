using System;

class CountDigits
{
    static void Main()
    {
        int number = 12345, count = 0;

        while (number != 0)
        {
            count++;
            number /= 10;
        }

        Console.WriteLine("Total Digits: " + count);
    }
}