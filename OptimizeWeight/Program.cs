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
     * Complete the 'minimalHeaviestSetA' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> minimalHeaviestSetA(List<int> arr)
    {
        List<int> a = new List<int>();
        arr.Sort();
        int sum = arr.Sum();
        // for(int i = 0; i < arr.Count - 1; i++){
        //     Console.WriteLine("element " + arr[i+1]);
        //     sum += arr[i+1];
        //     if(arr[i] > arr[i+1]){
        //         int temp = arr[i];
        //         arr[i] = arr[i+1];
        //         arr[i+1] = temp;                
        //     }                     
        // }


        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine("sorted element " + arr[i]);
        }

        Console.WriteLine("sum" + sum);

        int sumOfA = 0;
        int next = 0;
        for (int i = arr.Count - 1; i >= 0; i--)
        {
            sumOfA = sumOfA + arr[i];
            a.Add(arr[i]);
            if (i != 0)
            {
                next = arr[i - 1];
            }
            else
            {
                next = 0;
            }
            if (sumOfA > sum / 2 && arr[i] != next)
            {
                break;
            }
            else if (sumOfA > sum / 2 && arr[i] == next)
            {
                Console.WriteLine("found duplicate " + next);
                continue;
            }
            else
            {
                continue;
            }
        }
        return a;
    }

}
class Solution
{
    public static void Main(string[] args)
    {

        
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < arrCount; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        List<int> result = Result.minimalHeaviestSetA(arr);

        Console.WriteLine(String.Join("\n", result));
    }
}
