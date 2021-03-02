using System;

class Solution
{
    static int BeautifulDays(int i, int j, int k)
    {

    }

    static void Main()
    {
        string[] ijk = new string[] { "20", "23", "6" };

        int i = Convert.ToInt32(ijk[0]);
        int j = Convert.ToInt32(ijk[1]);
        int k = Convert.ToInt32(ijk[2]);

        int result = BeautifulDays(i, j, k);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
