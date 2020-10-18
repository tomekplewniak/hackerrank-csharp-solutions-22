using System;

class Solution
{
    static int SimpleArraySum(int[] ar)
    {

    }

    static void Main()
    {
        var testData = "1 2 3 4 10 11";

        int[] ar = Array.ConvertAll(testData.Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = SimpleArraySum(ar);

        Console.WriteLine(result);
    }
}
