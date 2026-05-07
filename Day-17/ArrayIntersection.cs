using System;
using System.Linq;

class ArrayIntersection {
    static void Main() {
        int[] a = {1,2,3};
        int[] b = {2,3,4};

        var res = a.Intersect(b);

        foreach (var i in res)
            Console.Write(i + " ");
    }
}