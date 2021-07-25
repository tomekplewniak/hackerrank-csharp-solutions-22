using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int MinimumDistances(List<int> a)
    {

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        var testCase = "7 1 3 4 1 7";

        List<int> a = testCase.TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.MinimumDistances(a);

        Console.WriteLine($"{result}");
    }
}
