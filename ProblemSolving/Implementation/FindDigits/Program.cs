using System;
using System.Collections.Generic;

class Solution
{
    static int FindDigits(int n)
    {
        int res = n;
        int c = 0;
        while (res > 0)
        {
            int d = res % 10;
            if (d != 0 && n % d == 0)
                c++;
            res /= 10;
        }
        return c;
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
