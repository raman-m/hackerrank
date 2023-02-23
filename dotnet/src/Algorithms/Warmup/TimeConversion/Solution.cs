namespace RamanM.HackerRank.Algorithms.Warmup.TimeConversion;

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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        string[] parts = s.Split(':');
        bool isAM = parts[2].Contains("AM");
        int hours = int.Parse(parts[0]);
        int minutes = int.Parse(parts[1]);
        int seconds = int.Parse(parts[2].Remove("AM".Length));
        if (isAM && hours == 12)
            hours = 0;
        else if (!isAM && hours < 12)
            hours += 12;

        return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
