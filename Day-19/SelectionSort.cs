using System;

class SelectionSort {
    static void Main() {
        int[] arr = {4, 7, 1, 9, 2};

        for (int i = 0; i < arr.Length; i++) {
            int min = i;

            for (int j = i + 1; j < arr.Length; j++) {
                if (arr[j] < arr[min])
                    min = j;
            }

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }

        foreach (int i in arr)
            Console.Write(i + " ");
    }
}