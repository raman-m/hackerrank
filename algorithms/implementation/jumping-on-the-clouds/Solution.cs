namespace RamanM.HackerRank.Algorithms.Implementation.JumpingOnTheClouds;

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
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public const int Cumulus = 0;
    public const int Thunderhead = 1;

    public static int jumpingOnClouds(List<int> c)
    {
        int jumps = 0;
        for (int i = 0, n = c.Count; i < n - 1; jumps++)
        {
            if (i + 2 < n && c[i + 2] != Thunderhead)
                i += 2;
            else if (i + 1 < n && c[i + 1] != Thunderhead)
                i += 1;
            else
                break;
        }
        return jumps;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
