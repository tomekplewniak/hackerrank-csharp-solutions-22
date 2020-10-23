using System.Collections.Generic;
using System;
using System.Linq;

class Result
{
    public static int BirthdayCakeCandles(List<int> candles)
    {
        var max = candles.Max();

        return candles.Count(val => val == max);
    }
}

class Solution
{
    public static void Main()
    {
        var candles = new List<int>() { 3, 2, 1, 3 };

        int result = Result.BirthdayCakeCandles(candles);

        Console.WriteLine(result);
    }
}
