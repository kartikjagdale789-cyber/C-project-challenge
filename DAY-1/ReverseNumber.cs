using System;

class ReverseNumber
{
    static void Main()
    {
        int number = 12345, reverse = 0;

        while (number != 0)
        
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        Console.WriteLine("Reversed Number: " + reverse);
    }
}