using System;

class Solution
{
    static long AVeryBigSum(long[] ar)
    {

    }

    static void Main()
    {
        var testData = "1000000001 1000000002 1000000003 1000000004 1000000005";

        long[] ar = Array.ConvertAll(testData.Split(' '), arTemp => Convert.ToInt64(arTemp));
        long result = AVeryBigSum(ar);

        Console.WriteLine(result);
    }
}
