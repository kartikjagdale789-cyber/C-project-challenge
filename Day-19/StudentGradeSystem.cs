using System;

class StudentGradeSystem {
    static void Main() {
        int marks = 85;

        if (marks >= 90) Console.WriteLine("A+");
        else if (marks >= 75) Console.WriteLine("A");
        else if (marks >= 60) Console.WriteLine("B");
        else Console.WriteLine("C");
    }
}