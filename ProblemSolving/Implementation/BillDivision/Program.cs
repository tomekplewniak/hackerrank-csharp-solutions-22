using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void BonAppetit(List<int> bill, int k, int b)
    {
        var sum = bill.Sum() - bill[k];

        if ((sum /2 ) == b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine($"{b - sum / 2}");
        }
    }

    static void Main()
    {
        int k = 1;

        List<int> bill = new List<int>() { 3, 10, 2, 9 };

        int b = 12;

        BonAppetit(bill, k, b);
    }
}
