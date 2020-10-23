using System.Collections.Generic;
using System;

class Result
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        var diag1 = 0;
        var diag2 = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                {
                    diag1 += arr[i][j];
                }

                if (i + j == arr.Count - 1)
                {
                    diag2 += arr[i][j];
                }
            }
        }

        return Math.Abs(diag1 - diag2);
    }
}

class Solution
{
    public static void Main()
    {
        List<List<int>> arr = new List<List<int>>()
        {
            new List<int>(){ 11, 2, 4 },
            new List<int>(){ 4, 5, 6 },
            new List<int>(){ 10, 8, -12 }
        };

        int result = Result.DiagonalDifference(arr);

        Console.WriteLine(result);
    }
}
