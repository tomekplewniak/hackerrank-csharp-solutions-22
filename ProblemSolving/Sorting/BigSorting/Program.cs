using System;
using System.Collections.Generic;

class Solution
{
    static string[] BigSorting(string[] unsorted)
    {

    }

    static void Main()
    {
        string[] unsorted = new string[]
        {
            "31415926535897932384626433832795",
            "1",
            "3",
            "10",
            "3",
            "5"
        };

        for (int i = 0; i < unsorted.Length; i++)
        {
            string unsortedItem = unsorted[i];
            unsorted[i] = unsortedItem;
        }

        string[] result = BigSorting(unsorted);

        Console.WriteLine(string.Join("\n", result));
    }
}
