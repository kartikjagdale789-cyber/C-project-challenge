using System;

class AutomorphicNumber {
    static void Main() {
        int num = 25;
        int sq = num * num;

        if (sq.ToString().EndsWith(num.ToString()))
            Console.WriteLine("Automorphic");
        else
            Console.WriteLine("Not");
    }
}