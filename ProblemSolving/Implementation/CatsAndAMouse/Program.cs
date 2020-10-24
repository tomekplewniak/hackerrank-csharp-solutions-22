using System;
using System.Collections.Generic;

class Solution
{
    static string CatAndMouse(int x, int y, int z)
    {

    }

    static void Main()
    {
        var testData = new List<List<int>>()
        {
            new List<int>(){1, 2, 3 },
            new List<int>(){1, 3, 2 }
        };

        for (int qItr = 0; qItr < testData.Count; qItr++)
        {
            int x = testData[qItr][0];

            int y = testData[qItr][1];

            int z = testData[qItr][2];

            string result = CatAndMouse(x, y, z);

            Console.WriteLine(result);
        }
    }
}
