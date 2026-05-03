using System;

class EnumDemo
{
    enum Days { Monday, Tuesday, Wednesday, Thursday, Friday }

    static void Main()
    {
        Days today = Days.Wednesday;

        Console.WriteLine("Today is: " + today);
        Console.WriteLine("Day number: " + (int)today);
    }
}