using System;

class CountWords {
    static void Main() {
        string str = "C Sharp Programming Language";
        string[] words = str.Split(' ');

        Console.WriteLine(words.Length);
    }
}