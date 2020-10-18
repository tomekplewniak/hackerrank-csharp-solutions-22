using System;
using System.Linq;

class Solution
{
    static void PlusMinus(int[] arr)
    {
        Console.WriteLine("{0:F6}", (double)arr.Count(x => x > 0) / arr.Count());
        Console.WriteLine("{0:F6}", (double)arr.Count(x => x < 0) / arr.Count());
        Console.WriteLine("{0:F6}", (double)arr.Count(x => x == 0) / arr.Count());
    }

    static void Main()
    {
        var testData = "-4 3 -9 0 4 1";

        int[] arr = Array.ConvertAll(testData.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        PlusMinus(arr);
    }
}
