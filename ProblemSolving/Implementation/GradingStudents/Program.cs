using System.Collections.Generic;
using System;

class Result
{
    public static List<int> GradingStudents(List<int> grades)
    {
        var result = new List<int>();

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                if ((grades[i] % 5) > 2)
                {
                    grades[i] += 5 - (grades[i] % 5);
                }
            }

            result.Add(grades[i]);
        }

        return result;
    }
}

class Solution
{
    public static void Main()
    {
        List<int> grades = new List<int>() { 73, 67, 38, 33 };

        List<int> result = Result.GradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
    }
}
