using System.Collections.Generic;
using System;

class Result
{
    public static List<int> GradingStudents(List<int> grades)
    {

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
