using System;
using System.Collections.Generic;

class Solution
{
    static int FindDigits(int n)
    {

    }

    static void Main()
    {
        List<int> testData = new List<int>() { 12, 1012 };

        for (int tItr = 0; tItr < testData.Count; tItr++)
        {
            int result = FindDigits(testData[tItr]);

            Console.WriteLine(result);
        }
    }
}
