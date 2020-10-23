using System.Collections.Generic;
using System;

class Result
{
    public static int DiagonalDifference(List<List<int>> arr)
    {

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
