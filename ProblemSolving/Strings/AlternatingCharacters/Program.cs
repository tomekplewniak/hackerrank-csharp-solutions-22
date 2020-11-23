using System;

class Solution
{
    static int AlternatingCharacters(string s)
    {
        var deletions = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i+1])
            {
                deletions++;
            }
        }

        return deletions;
    }

    static void Main()
    {
        var testData = "AAABBB";

        int result = AlternatingCharacters(testData);

        Console.WriteLine(result);
    }
}
