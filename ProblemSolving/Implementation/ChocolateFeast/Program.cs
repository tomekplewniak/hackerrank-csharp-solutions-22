using System;

class Result
{
    public static int ChocolateFeast(int n, int c, int m)
    {
        int chocolates = n / c;
        int answer = chocolates + ChocolateRec(chocolates, m);
        return answer;
    }

    static int ChocolateRec(int chocolates, int m)
    {

        if (chocolates < m) return 0;
        return 1 + ChocolateRec(chocolates - m + 1, m);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // n: Bobby's initial amount of money
        int n = 15;

        // c: the cost of a chocolate bar
        int c = 3;

        // m: the number of wrappers he can turn in for a free bar
        int m = 2;

        int result = Result.ChocolateFeast(n, c, m);
        Console.WriteLine(result);
    }
}
