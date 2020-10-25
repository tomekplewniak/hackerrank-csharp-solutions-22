using System;
using System.Linq;

class Solution
{
    static int Camelcase(string s)
    {
        var wordsCounter = 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsUpper(s[i]))
            {
                wordsCounter++;
            }
        }

        return wordsCounter;
    }

    static void Main()
    {
        string s = "saveChangesInTheEditor";

        int result = Camelcase(s);

        Console.WriteLine(result);
    }
}
