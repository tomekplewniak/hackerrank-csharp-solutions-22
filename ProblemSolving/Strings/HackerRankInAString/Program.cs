using System;
using System.Collections.Generic;

class Solution
{
    static string HackerrankInString(string s)
    {
        var hackerrank = new Queue<char>("hackerrank".ToCharArray());

        foreach (var c in s)
        {
            if (c == hackerrank.Peek())
            {
                hackerrank.Dequeue();
            }

            if (hackerrank.Count == 0)
            {
                return "YES";
            }
        }

        return "NO";
    }

    static void Main()
    {
        var testData = new List<string>()
        {
            "hhaacckkekraraannk",
            "rhbaasdndfsdskgbfefdbrsdfhuyatrjtcrtyytktjjt"
        };

        for (int qItr = 0; qItr < testData.Count; qItr++)
        {
            string s = testData[qItr];

            string result = HackerrankInString(s);

            Console.WriteLine(result);
        }
    }
}
