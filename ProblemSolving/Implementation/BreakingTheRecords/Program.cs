using System;

class Solution
{
    static int[] BreakingRecords(int[] scores)
    {
        var best = scores[0];
        var bestCouner = 0;

        var worst = scores[0];
        var worstCounter = 0;

        foreach (var i in scores)
        {
            if (i > best)
            {
                best = i;
                bestCouner++;
            }

            if (i < worst)
            {
                worst = i;
                worstCounter++;
            }
        }

        return new int[] { bestCouner, worstCounter };
    }

    static void Main()
    {
        var testData = "3 4 21 36 10 28 35 5 24 42";

        int[] scores = Array.ConvertAll(testData.Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
        int[] result = BreakingRecords(scores);

        Console.WriteLine(string.Join(" ", result));
    }
}
