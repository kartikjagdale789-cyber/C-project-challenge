using System;

class SplitString
{
    static void Main()
    {
        string text = "C Sharp Programming Language";

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}