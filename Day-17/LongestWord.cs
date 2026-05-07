using System;

class LongestWord {
    static void Main() {
        string str = "C sharp is powerful";
        string[] words = str.Split(' ');
        string max = "";

        foreach (string w in words) {
            if (w.Length > max.Length)
                max = w;
        }

        Console.WriteLine(max);
    }
}