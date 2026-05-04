using System;

class CountWords
{
    static void Main()
    {
        string str = "C sharp programming language";
        string[] words = str.Split(' ');

        Console.WriteLine("Number of words: " + words.Length);
    }
}