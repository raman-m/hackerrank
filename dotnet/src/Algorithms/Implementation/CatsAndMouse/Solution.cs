﻿namespace RamanM.HackerRank.Algorithms.Implementation.CatsAndMouse;

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

public class Solution
{
    const string CatA = "Cat A", CatB = "Cat B", MouseC = "Mouse C";

    // Complete the catAndMouse function below.
    public static string catAndMouse(int x, int y, int z)
    {
        int distanceA = Math.Abs(z - x);
        int distanceB = Math.Abs(z - y);

        if (distanceA == distanceB)
            return MouseC;
        else if (distanceA < distanceB)
            return CatA;
        else
            return CatB;
    }

    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
