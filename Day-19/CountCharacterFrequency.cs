using System;
using System.Collections.Generic;

class CountCharacterFrequency {
    static void Main() {
        string str = "hello";
        Dictionary<char, int> d = new Dictionary<char, int>();

        foreach (char c in str) {
            if (d.ContainsKey(c)) d[c]++;
            else d[c] = 1;
        }

        foreach (var item in d)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}