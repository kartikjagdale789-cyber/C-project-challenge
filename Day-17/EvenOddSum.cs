using System;

class EvenOddSum {
    static void Main() {
        int[] arr = {1,2,3,4,5};
        int even = 0, odd = 0;

        foreach (int i in arr) {
            if (i % 2 == 0) even += i;
            else odd += i;
        }

        Console.WriteLine($"Even={even}, Odd={odd}");
    }
}