using System;
using System.Linq;

class Solution
{
    static void MiniMaxSum(int[] arr)
    {
        long sum = 0;

        foreach (var a in arr)
        {
            sum += a;
        }

        Console.WriteLine("{0} {1}", sum - arr.Max(), sum - arr.Min());
    }

    static void Main()
    {
        var testData = "1 2 3 4 5";

        int[] arr = Array.ConvertAll(testData.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        MiniMaxSum(arr);
    }
}
