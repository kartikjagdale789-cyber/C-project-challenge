using System;
using System.Collections.Generic;

class FrequencyArray {
    static void Main() {
        int[] arr = {1,2,2,3};
        Dictionary<int,int> d = new Dictionary<int,int>();

        foreach (int i in arr) {
            if (d.ContainsKey(i)) d[i]++;
            else d[i] = 1;
        }

        foreach (var x in d)
            Console.WriteLine(x.Key + ":" + x.Value);
    }
}