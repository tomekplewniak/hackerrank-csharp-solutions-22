using System;
using System.Linq;

class Solution
{
    static string FairRations(int[] b)
    {
        int oddNumbers = b.Select(c => c % 2 == 0 ? 0 : 1).Sum();

        if (oddNumbers % 2 == 1)
        {
            return "NO";
        }

        int breadNum = 0;
        for (int i = 0; i < b.Length - 1; i++)
        {
            if (b[i] % 2 == 1)
            {
                b[i] += 1;
                b[i + 1] += 1;
                breadNum += 2;
            }
        }
        return breadNum.ToString();
    }

    static void Main()
    {
        int[] b = new int[] { 2, 3, 4, 5, 6 };

        var result = FairRations(b);
        Console.WriteLine(result);
    }
}
