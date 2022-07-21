using System;
using System.Linq;

namespace AlgoAndDataStrcuture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please press any key to continue: ");
            Console.ReadKey();
            Console.WriteLine("Following are the problem statements. select the one you want to run \n" +
                "A. Find one missing number from an array that 1 to 100 numbers \n" +
                "B. Find multiple missing numbers from an array \n" +
                "C. Find duplicate numbers from an array \n" +
                "D. Find the largest sum of a collection of contigious elements in an array \n");
            string prob = Console.ReadLine();

            switch (prob.ToUpperInvariant())
            {
                case "A":
                    int[] arr = new int[] {1, 2, 3, 4, 5, 6, 7 , 8, 9, 10, 12, 13 , 14 , 15, 16, 17, 18, 19 , 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
                    int num = FindMissingNumber(arr, arr.Length);
                    Console.WriteLine("the missing number is " + num);
                    break;

                case "B":
                    //MISSING NUMBERS ARE 11 AND 15
                    int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 13, 14, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
                    FindMultipleMissingNumber(arr1, arr1.Length);
                    break;
                case "D":
                    //int[] arr2 = new int[] { 2, 4, 6, -2, 4, -3, 15, 4, -4, 0, 4 , 5, 1, -7 };
                    int[] arr2 = new int[] { 2, -4, -6, -2, -4, -3, -15, -4, -4, -1, -4, -5, -2, -7 };
                    int sum = FindGreatestSubArrSum(arr2, arr2.Length);
                    Console.WriteLine("Maximum contiguous sum is " + sum);
                    break;
                case "E":
                    //int[] arr2 = new int[] { 2, 4, 6, -2, 4, -3, 15, 4, -4, 0, 4 , 5, 1, -7 };
                    int[] arr3 = new int[] { 2, -4, -6, -2, -4, -3, -15, -4, -4, -1, -4, -5, -2, -7 };
                 
                    break;
            }
            
        }

        public static int[] Init(int arrayLength)
        {
            int[] arr = new int[arrayLength];            
            for (int i = 0; i < arrayLength; i++)
            {
                if(i == 9)
                {
                    continue;
                }
                arr[i] = i + 1;                
            }
            return arr;
        }

        public static int FindMissingNumber(int[] arr, int arrayLength)
        {
            int totExpSum = (30 * (30 + 1)) / 2;
            int actualSum = 0;
            for(int i = 0; i < arrayLength; i++)
            {
                actualSum += arr[i];
            }

            return totExpSum - actualSum;
        }

        public static void FindMultipleMissingNumber(int[] arr, int arrayLength)
        {
            Console.WriteLine("the expected nos in array are " + 30);
            Console.WriteLine("the actual nos in array are " + arrayLength);
            int missinCount = 30 - arrayLength;
            Console.WriteLine("the missing nos count in array is " + missinCount);
            int count = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != count)
                {
                    if(i == 10)
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine(count);
                    missinCount--;
                    if(missinCount == 0)
                    {
                        break;
                    }
                    count++;
                }
                count++;
            }
        }

        public static int FindGreatestSubArrSum(int[] arr, int arrayLength)
        {
            int greatestSum = arr[0];
            int subSum = arr[0];
            for(int i = 1; i < arrayLength; i++)
            {
                if(subSum < 0)
                {
                    subSum = arr[i];
                }
                else
                {
                    subSum += arr[i];
                }

                if(greatestSum < subSum)
                {
                    greatestSum = subSum;
                }
            }

            return greatestSum;
        }
    }
}
