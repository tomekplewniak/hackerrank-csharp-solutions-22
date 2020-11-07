using System;
using System.Linq;

class Solution
{
    static int HurdleRace(int k, int[] height)
    {
        if (height.Max() - k > 0)
        {
            return height.Max() - k;
        }
        else
        {
            return 0;
        }
    }

    static void Main()
    {
        int k = 4;

        int[] height = new int[] { 1, 6, 3, 5, 2 };

        int result = HurdleRace(k, height);

        Console.WriteLine(result);
    }
}
