using System;

class StrongNumber {
    static int Fact(int n) {
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        return f;
    }

    static void Main() {
        int num = 145, temp = num, sum = 0;
        while (temp > 0) {
            int d = temp % 10;
            sum += Fact(d);
            temp /= 10;
        }
        Console.WriteLine(sum == num ? "Strong" : "Not Strong");
    }
}