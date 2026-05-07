using System;

class BinarySearch {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        int key = 4, low = 0, high = arr.Length - 1;

        while (low <= high) {
            int mid = (low + high) / 2;

            if (arr[mid] == key) {
                Console.WriteLine("Found at " + mid);
                return;
            }

            if (arr[mid] < key) low = mid + 1;
            else high = mid - 1;
        }

        Console.WriteLine("Not Found");
    }
}