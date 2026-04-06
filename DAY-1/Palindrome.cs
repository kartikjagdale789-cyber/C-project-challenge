using System;

class Palindrome
{
    static void Main()
    {
        int number = 121, temp = number, reverse = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp /= 10;
        }

        if (number == reverse)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not Palindrome");
    }
}