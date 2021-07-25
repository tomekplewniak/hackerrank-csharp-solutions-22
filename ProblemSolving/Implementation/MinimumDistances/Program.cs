using System.Collections.Generic;
using System.Linq;
using System;

class Result
{
    public static int MinimumDistances(List<int> a)
    {
        int shortestDistance = a.Count + 1;
        for (int i = 0; i < a.Count - 1; i++)
        {
            int index = a.IndexOf(a[i], i + 1);
            if (index == -1) continue;

            int distance = Math.Abs(index - i);
            if (distance < shortestDistance)
                shortestDistance = distance;
        }

        return shortestDistance != a.Count + 1 ? shortestDistance : -1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        var testCase = "7 1 3 4 1 7";

        List<int> a = testCase.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.MinimumDistances(a);

        Console.WriteLine($"{result}");
    }
}
