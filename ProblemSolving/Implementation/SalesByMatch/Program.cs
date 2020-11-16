using System;
using System.Linq;
using System.Threading.Tasks;

class Solution
{
    static int SockMerchant(int n, int[] ar)
    {
        var allSize = ar.Select(a => a).Distinct();

        var result = 0;

        Parallel.ForEach(allSize, size =>
        {
            var count = (from a in ar
                         where
                         a == size
                         select a).Count();

            result += count / 2;
        });

        return result;
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
