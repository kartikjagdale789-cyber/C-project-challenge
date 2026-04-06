using System;

class Temperature
{
    static void Main()
    {
        double celsius = 37;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit: " + fahrenheit);
    }
}