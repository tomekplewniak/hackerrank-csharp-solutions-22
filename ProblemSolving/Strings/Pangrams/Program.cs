using System;
using System.Collections.Generic;

class Solution
{
    static string Pangrams(string s)
    {
        List<char> alphabet = new List<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());

        foreach (var c in s)
        {
            if (alphabet.Contains(Char.ToLower(c)))
            {
                alphabet.Remove(Char.ToLower(c));
            }
        }

        if (alphabet.Count == 0)
        {
            return "pangram";
        }
        else
        {
            return "not pangram";
        }
    }

    static void Main()
    {
        string s = "We promptly judged antique ivory buckles for the next prize";

        string result = Pangrams(s);

        Console.WriteLine(result);
    }
}
