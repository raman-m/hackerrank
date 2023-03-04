namespace RamanM.HackerRank.Algorithms.Implementation.GradingStudents;

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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public const int FailingGrade = 40;

    public static List<int> gradingStudents(List<int> grades)
    {
        if (grades?.Count == 0)
            return new List<int>(0);

        var rounded = new List<int>(grades.Count);
        foreach (int grade in grades)
        {
            int rounding = grade % 5 > 0
                ? grade + 5 - grade % 5
                : grade;
            int graded = rounding - grade < 3 && rounding >= FailingGrade
                ? rounding
                : grade;
            rounded.Add(graded);
        }
        return rounded;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join(Environment.NewLine, result));

        textWriter.Flush();
        textWriter.Close();
    }
}
