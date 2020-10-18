using System;

class Solution
{
    static string TimeConversion(string s)
    {
        var sArray = s.Split(':');

        var hh = sArray[0];
        var mm = sArray[1];
        var ss = sArray[2].Remove(2);

        if (s.Contains("AM"))
        {
            if (hh.Contains("12"))
            {
                hh = "00";
            }

            return $"{hh}:{mm}:{ss}";
        }
        else
        {
            if (hh.Contains("12") == false)
            {
                hh = (Convert.ToInt32(hh) + 12).ToString();
            }

            return $"{hh}:{mm}:{ss}";
        }
    }

    static void Main()
    {
        string s = "07:05:45PM";

        string result = TimeConversion(s);
        
        Console.WriteLine(result);
    }
}
