using System;

class DecimalToBinary {
    static void Main() {
        int num = 10;
        string bin = "";
        while (num > 0) {
            bin = (num % 2) + bin;
            num /= 2;
        }
        Console.WriteLine(bin);
    }
}