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



class Result
{

    /*
     * Complete the 'processLogs' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY logs
     *  2. INTEGER threshold
     */

    public static List<string> processLogs(List<string> logs, int threshold)
    {
        List<string> li = new List<string>();
        Hashtable hash = new Hashtable();
        foreach (string log in logs)
        {
            string[] arr = log.Split(" ");
            if (hash.ContainsKey(arr[0]){
                if (hash[arr[0]] < threshold)
                {
                    hash[arr[0]]++;
                }
                if (hash[arr[0]] > threshold)
                {
                    li.Add(arr[0]);
                }
            }
            else
            {
                hash[arr[0]] = 1;
            }
            if (hash.ContainsKey(arr[1]){
                if (hash[arr[1]] < threshold)
                {
                    hash[arr[1]]++;
                }
                if (hash[arr[1]] > threshold)
                {
                    li.Add(arr[1]);
                }
            }
            else
            {
                hash[arr[1]] = 1;
            }
        }

        return li;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int logsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> logs = new List<string>();

        for (int i = 0; i < logsCount; i++)
        {
            string logsItem = Console.ReadLine();
            logs.Add(logsItem);
        }

        int threshold = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> result = Result.processLogs(logs, threshold);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
