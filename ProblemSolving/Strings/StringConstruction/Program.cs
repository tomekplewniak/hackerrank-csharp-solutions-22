using System;
using System.Linq;

class Solution
{
    static int StringConstruction(string s)
    {
        return s.Distinct().Count();
    }

    static void Main()
    {
        var testData = "abab";

        int result = StringConstruction(testData);

        Console.WriteLine(result);
    }
}
