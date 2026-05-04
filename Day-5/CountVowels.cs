using System;

class CountVowels
{
    static void Main()
    {
        string str = "Hello World";
        int count = 0;

        foreach (char ch in str.ToLower())
        {
            if ("aeiou".Contains(ch))
                count++;
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}