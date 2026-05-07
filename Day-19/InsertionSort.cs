using System;

class InsertionSort {
    static void Main() {
        int[] arr = {8, 4, 6, 2, 1};

        for (int i = 1; i < arr.Length; i++) {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

        foreach (int i in arr)
            Console.Write(i + " ");
    }
}