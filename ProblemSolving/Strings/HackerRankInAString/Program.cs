using System;
using System.Collections.Generic;

class Solution
{
    static string HackerrankInString(string s)
    {

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
