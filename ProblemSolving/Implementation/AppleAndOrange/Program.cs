using System;

class Solution
{
    static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        var applesCount = 0;
        var orangesCount = 0;

        for (int i = 0; i < apples.Length; i++)
        {
            if (a + apples[i] >= s && a + apples[i] <= t)
            {
                applesCount++;
            }
        }

        Console.WriteLine(applesCount);

        for (int i = 0; i < oranges.Length; i++)
        {
            if (b + oranges[i] >= s && b + oranges[i] <= t)
            {
                orangesCount++;
            }
        }

        Console.WriteLine(orangesCount);
    }

    static void Main()
    {
        int s = 7;
        int t = 11;
        int a = 5;
        int b = 15;

        int[] apples = new int[] { -2, 2, 1 };

        int[] oranges = new int[] { 5, -6 };

        CountApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
