using System;

class Solution
{
    static long StrangeCounter(long t)
    {
        long initialValue = 3;
        while (initialValue <= t + 2)
        {
            initialValue *= 2;
        }

        return initialValue - t - 2;
    }

    static void Main()
    {
        long t = 4;

        long result = StrangeCounter(t);

        Console.WriteLine(result);
    }
}
