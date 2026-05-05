using System;
using System.Text.RegularExpressions;

class RemoveSpecialCharacters
{
    static void Main()
    {
        string text = "Hello@Ajay#2026!";

        string result = Regex.Replace(text, "[^a-zA-Z0-9]", "");

        Console.WriteLine("Result: " + result);
    }
}