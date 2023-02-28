namespace RamanM.HackerRank.Algorithms.Implementation.ElectronicsShop;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
    /*
     * Complete the getMoneySpent function below.
     */
    public static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        if (b <= 0 || keyboards?.Length == 0 || drives?.Length == 0)
            return -1;

        int max = -1;
        foreach (int keyboard in keyboards)
            foreach (int drive in drives)
            {
                int cost = keyboard + drive;
                if (cost <= b && cost > max)
                    max = cost;
            }
        return max;
    }

    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
