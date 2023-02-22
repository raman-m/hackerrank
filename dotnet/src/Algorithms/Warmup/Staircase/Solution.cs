namespace RamanM.HackerRank.Algorithms.Warmup.Staircase;

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

public class Result
{
    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        if (n <= 0)
            Console.Write(string.Empty);

        var b = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            b.Append(new string(' ', n - i));
            b.Append(new string('#', i));
            if (i < n) b.AppendLine();
        }
        Console.Write(b.ToString());
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
