using System;
using System.Linq;

class Solution
{
    static int IntroTutorial(int V, int[] arr)
    {
        return Array.IndexOf(arr, V);
    }

    static void Main()
    {
        int V = 4;

        int[] arr = new int[] { 1, 4, 5, 7, 9, 12 };

        int result = IntroTutorial(V, arr);

        Console.WriteLine(result);
    }
}
