using System;

class Solution
{
    static int ViralAdvertising(int n)
    {
        var likePerDay = 0;
        var person = 5;

        var allLikes = 0;

        for (int i = 0; i < n; i++)
        {
            likePerDay = person / 2;

            person = likePerDay * 3;

            allLikes += likePerDay;
        }

        return allLikes;
    }

    static void Main()
    {
        int n = 3;

        int result = ViralAdvertising(n);

        Console.WriteLine(result);
    }
}
