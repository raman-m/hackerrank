namespace RamanM.HackerRank.Algorithms.Warmup.MiniMaxSum;

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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int n = arr.Count;

        long sum = 0L;
        foreach (int element in arr)
        {
            sum += element;
        }

        long min = long.MaxValue, max = long.MinValue;
        foreach (int element in arr)
        {
            long s = sum - element;
            min = Math.Min(min, s);
            max = Math.Max(max, s);
        }
        Console.Write($"{min} {max}");
    }
}

public class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
