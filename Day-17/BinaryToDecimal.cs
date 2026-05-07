using System;

class BinaryToDecimal {
    static void Main() {
        int binary = 1011, decimalNum = 0, baseVal = 1;
        while (binary > 0) {
            int last = binary % 10;
            decimalNum += last * baseVal;
            baseVal *= 2;
            binary /= 10;
        }
        Console.WriteLine(decimalNum);
    }
}