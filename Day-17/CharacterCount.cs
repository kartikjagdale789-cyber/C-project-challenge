using System;

class CharacterCount {
    static void Main() {
        string s = "Hello123";
        int u=0,l=0,d=0;

        foreach (char c in s) {
            if (char.IsUpper(c)) u++;
            else if (char.IsLower(c)) l++;
            else if (char.IsDigit(c)) d++;
        }

        Console.WriteLine($"U:{u} L:{l} D:{d}");
    }
}