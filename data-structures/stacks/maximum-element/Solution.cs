namespace RamanM.HackerRank.DataStructures.Stacks.MaximumElement;

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
    private readonly Stack<int> stack;
    private readonly Stack<int> maxStack;

    public Result()
    {
        stack = new Stack<int>();
        maxStack = new Stack<int>();
    }

    private void Push(string operation)
    {
        string str = operation.Split(' ')[1];
        int value = int.Parse(str);

        stack.Push(value);
        
        if (maxStack.Count == 0)
            maxStack.Push(value);
        else if (value >= maxStack.Peek())
            maxStack.Push(value);
    }

    private int Pop()
    {
        if (stack.Count == 0)
            return 0;

        int popped = stack.Pop();
        if (popped >= maxStack.Peek())
            maxStack.Pop();

        return popped;
    }

    private bool Empty()
    {
        return stack.Count == 0;
    }

    private int Max()
    {
        return maxStack.Peek();
    }

    public static List<int> GetMax(List<string> operations)
    {
        if (operations == null || operations.Count == 0)
            return new List<int>(0);

        var result = new List<int>();
        var helper = new Result();
        foreach (string operation in operations)
        {
            if (string.IsNullOrEmpty(operation))
                continue;

            char type = operation.First();
            switch (type)
            {
                case '1':
                    helper.Push(operation);
                    break;
                case '2':
                    if (helper.Empty())
                        continue;
                    helper.Pop();
                    break;
                case '3':
                    if (!helper.Empty())
                        result.Add(helper.Max());
                    break;
                default:
                    continue;
            }
        }
        return result;
    }
}

public class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> ops = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string opsItem = Console.ReadLine();
            ops.Add(opsItem);
        }

        List<int> res = Result.GetMax(ops);

        textWriter.WriteLine(String.Join(Environment.NewLine, res));

        textWriter.Flush();
        textWriter.Close();
    }
}
