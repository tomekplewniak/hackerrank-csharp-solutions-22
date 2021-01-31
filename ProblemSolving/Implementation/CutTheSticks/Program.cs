using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int[] CutTheSticks(int[] arr)
    {
        var result = new List<int>();
        while (arr.Length > 0)
        {
            result.Add(arr.Length);

            arr = arr.Where(val => val != arr.Min()).ToArray();
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };
        
        int[] result = CutTheSticks(arr);

        Console.WriteLine(string.Join("\n", result));
    }
}
