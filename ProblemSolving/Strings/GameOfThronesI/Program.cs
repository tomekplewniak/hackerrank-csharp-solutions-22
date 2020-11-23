using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static string GameOfThrones(string s)
    {
        HashSet<char> oddLetters = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (oddLetters.Contains(s[i]))
            {
                oddLetters.Remove(s[i]);
            }
            else
            {
                oddLetters.Add(s[i]);
            }
        }

        if (s.Length % 2 == 0)
        {
            return oddLetters.Count == 0 ? "YES" : "NO";
        }
        else
        {
            return oddLetters.Count == 1 ? "YES" : "NO";
        }
    }

    static void Main()
    {
        var testData = "cdcdcdcdeeeef";

        string result = GameOfThrones(testData);

        Console.WriteLine(result);
    }
}
