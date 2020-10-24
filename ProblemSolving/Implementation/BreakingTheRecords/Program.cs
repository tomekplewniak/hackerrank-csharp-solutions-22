using System;

class Solution
{
    static int[] BreakingRecords(int[] scores)
    {

    }

    static void Main()
    {
        var testData = "3 4 21 36 10 28 35 5 24 42";

        int[] scores = Array.ConvertAll(testData.Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int[] result = BreakingRecords(scores);

        Console.WriteLine(string.Join(" ", result));
    }
}
