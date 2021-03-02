using System;
using System.Linq;

class Solution
{
    static int EqualizeArray(int[] arr)
    {
        var groupedList = from l in arr
                          group l by l into grp
                          orderby grp.Count() descending
                          select new { Value = grp.Key, Count = grp.Count() };

        var offtenValue = groupedList.First().Value;
                  
        return arr.Count(i => i != offtenValue);
    }

    static void Main()
    {
        var arr = new int[] { 3, 3, 2, 1, 3 };

        int result = EqualizeArray(arr);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
