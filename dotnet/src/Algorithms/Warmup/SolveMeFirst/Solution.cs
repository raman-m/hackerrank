﻿namespace RamanM.HackerRank.Algorithms.Warmup.SolveMeFirst;

public static class Solution
{
    public static int solveMeFirst(int a, int b)
    {
        // Hint: Type return a+b; below  
        return a + b;
    }

    public static void Main(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}
