using System;
using System.Collections.Generic;

class BalancedParentheses {
    static void Main() {
        string s = "{[]}";
        Stack<char> st = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[')
                st.Push(c);
            else st.Pop();
        }

        Console.WriteLine(st.Count == 0 ? "Balanced" : "Not");
    }
}