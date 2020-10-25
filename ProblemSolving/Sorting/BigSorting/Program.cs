using System;

class Solution
{
    static string[] BigSorting(string[] unsorted)
    {
        Array.Sort(unsorted, (string a, string b) => {
            if (a.Length == b.Length)
                return string.Compare(a, b, StringComparison.Ordinal);
            return a.Length - b.Length;
        });

        return unsorted;
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
