namespace RamanM.HackerRank.Algorithms.Warmup.PlusMinus;

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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count, positive = 0, negative = 0, zero = 0;
        foreach (int element in arr)
        {
            if (element < 0)
                negative++;
            else if (element > 0)
                positive++;
            else
                zero++;
        }
        double posRatio = (double)positive / n;
        double negRatio = (double)negative / n;
        double zeroRatio = (double)zero / n;
        Console.WriteLine(posRatio.ToString("F6"));
        Console.WriteLine(negRatio.ToString("F6"));
        Console.Write(zeroRatio.ToString("F6"));
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
