using System;

class Armstrong
{
    static void Main()
    {
        int number = 153, temp = number, sum = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }

        if (number == sum)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong");
    }
}