using System;

class ReplaceSubstring
{
    static void Main()
    {
        Console.Write("Enter main string: ");
        string str = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new substring: ");
        string newWord = Console.ReadLine();

        string result = str.Replace(oldWord, newWord);

        Console.WriteLine("Updated string: " + result);
    }
}