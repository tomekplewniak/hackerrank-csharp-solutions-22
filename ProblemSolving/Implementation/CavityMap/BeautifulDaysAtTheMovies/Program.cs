using System;
using System.Linq;
using System.Text;

class Solution
{
    static int BeautifulDays(int i, int j, int k)
    {
        var beautifulDaysCounter = 0;

        if (i < j)
        {
            for (int dayNumb = i; dayNumb <= j; dayNumb++)
            {
                var reversedDayNumb = Reverse(dayNumb);

                if ((dayNumb - reversedDayNumb) % k == 0)
                {
                    beautifulDaysCounter++;
                }
            }
        }

        return beautifulDaysCounter;
    }

    private static int Reverse(int number)
    {
        if (number.ToString().Length > 1)
        {
            var day = number.ToString().Reverse().ToArray();

            return Convert.ToInt32(new string(day));
        }
        else
        {
            return number;
        }
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
