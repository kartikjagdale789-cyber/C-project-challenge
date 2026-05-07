using System;
using System.Linq;

class RemoveDuplicatesString {
    static void Main() {
        string str = "programming";
        string result = new string(str.Distinct().ToArray());

        Console.WriteLine(result);
    }
}