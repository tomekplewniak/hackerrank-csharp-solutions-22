using System.Collections.Generic;
using System;

class Solution
{
    static List<int> CompareTriplets(List<int> a, List<int> b)
    {

    }

    static void Main()
    {
        var a = new List<int>() { 5, 6, 7 };

        var b = new List<int>() { 3, 6, 10 };

        List<int> result = CompareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}
