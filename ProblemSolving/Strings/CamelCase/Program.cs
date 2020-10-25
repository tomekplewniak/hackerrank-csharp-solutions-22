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

    static int CamelcaseByLinq(string s)
    {
        return s.Count(c => Char.IsUpper(c)) + 1;
    }

    static void Main()
    {
        string s = "saveChangesInTheEditor";

        Console.WriteLine("Solve by for loop:");
        int result = Camelcase(s);
        Console.WriteLine(result);

        Console.WriteLine("Solve by LINQ:");
        int secondResult = CamelcaseByLinq(s);

        Console.WriteLine(secondResult);
    }
}
