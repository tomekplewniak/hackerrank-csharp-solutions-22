using System;

class Solution
{
    static void PlusMinus(int[] arr)
    {

    }

    static void Main()
    {
        var testData = "-4 3 -9 0 4 1";

        int[] arr = Array.ConvertAll(testData.Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        PlusMinus(arr);
    }
}
