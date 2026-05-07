using System;

class RightRotateArray {
    static void Main() {
        int[] arr = {1,2,3,4,5};
        int last = arr[arr.Length - 1];

        for (int i = arr.Length - 1; i > 0; i--)
            arr[i] = arr[i - 1];

        arr[0] = last;

        foreach (int i in arr)
            Console.Write(i + " ");
    }
}