using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main()
    {
        string text = "My phone number is 9876543210";

        string pattern = @"\d+";

        Match match = Regex.Match(text, pattern);

        Console.WriteLine("Numbers found: " + match.Value);
    }
}