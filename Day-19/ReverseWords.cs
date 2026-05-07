using System;

class ReverseWords {
    static void Main() {
        string str = "Hello World";
        string[] words = str.Split(' ');
        Array.Reverse(words);

        Console.WriteLine(string.Join(" ", words));
    }
}