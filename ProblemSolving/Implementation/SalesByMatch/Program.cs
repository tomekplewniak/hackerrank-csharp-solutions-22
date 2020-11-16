using System;

class Solution
{
    static int SockMerchant(int n, int[] ar)
    {

    }

    static void Main()
    {
        var n = 9;
        var testData = "10 20 20 10 10 30 50 10 20";
        
        int[] ar = Array.ConvertAll(testData.Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = SockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
