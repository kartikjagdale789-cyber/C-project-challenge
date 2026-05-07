using System;

class RandomPassword {
    static void Main() {
        string chars = "abcABC123";
        Random r = new Random();
        string pass = "";

        for (int i = 0; i < 8; i++)
            pass += chars[r.Next(chars.Length)];

        Console.WriteLine(pass);
    }
}