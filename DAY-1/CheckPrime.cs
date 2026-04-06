using System;

class CheckPrime
{
    static void Main()
    {
        int number = 7, count = 0;

        for (int i = 1; i <= number; i++)
        
        {
            if (number % i == 0)
                count++;
        }

        if (count == 2)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not Prime");
    }
}