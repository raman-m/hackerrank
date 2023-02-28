namespace RamanM.HackerRank.Algorithms.Implementation.CountingValleys;

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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public const char Uphill = 'U';
    public const char Downhill = 'D';

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0;
        bool enteringValley = true;
        var stepUp = new Stack<char>();
        var stepDown = new Stack<char>();
        var hike = path.Take(steps);

        foreach (char step in hike)
        {
            if (step == Uphill)
                stepUp.Push(step);
            else if (step == Downhill)
                stepDown.Push(step);

            int seaLevel = stepUp.Count - stepDown.Count;
            if (seaLevel == 0)
            {
                stepUp.Clear();
                stepDown.Clear();
                enteringValley = true;
            }
            else if (seaLevel > 0)
            {
                enteringValley = false;
            }
            else if (seaLevel < 0 && enteringValley)
            {
                valleys++;
                enteringValley = false;
            }
        }
        return valleys;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
