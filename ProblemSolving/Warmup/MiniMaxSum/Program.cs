using System;

class Solution
{
    static void MiniMaxSum(int[] arr)
    {

    }

    static void Main()
    {
        var testData = "1 2 3 4 5";

        int[] arr = Array.ConvertAll(testData.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        MiniMaxSum(arr);
    }
}
