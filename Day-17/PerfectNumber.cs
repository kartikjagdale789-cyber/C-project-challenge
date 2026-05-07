using System;

class PerfectNumber {
    static void Main() {
        int n = 28, sum = 0;
        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0) sum += i;
        }
        Console.WriteLine(sum == n ? "Perfect Number" : "Not Perfect");
    }
}