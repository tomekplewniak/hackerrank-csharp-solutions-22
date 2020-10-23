using System.Collections.Generic;
using System;
using System.Linq;

class Solution
{
    static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        var aCount = a.Count();
        var bCount = a.Count();

        var alice = 0;
        var bob = 0;

        if (aCount >= 1 || aCount <= 100
            || bCount >= 1 || bCount <= 100
            && aCount == bCount)
        {
            for (int i = 0; i < aCount; i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }

                if (a[i] < b[i])
                {
                    bob++;
                }
            }

            return new List<int> { alice, bob };
        }
        else
        {
            throw new ArgumentException("Wrong input data.");
        }
    }

    static void Main()
    {
        var a = new List<int>() { 5, 6, 7 };

        var b = new List<int>() { 3, 6, 10 };

        List<int> result = CompareTriplets(a, b);

        Console.WriteLine(String.Join(" ", result));
    }
}
