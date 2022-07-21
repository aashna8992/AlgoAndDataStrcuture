// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int[] arr = new int[9] {1, 4, 5, 2, 6, 7, 9, 8, 10 };
//Console.WriteLine(findMissingNo(arr));
//findSubArrayWithGivenSum(arr);

int[] arr = new int[11] {6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7};
getArraysWithSumZero(arr);

int findMissingNo(int[] arr)
{
    int sumOf10 = (10 * (10 + 1)) / 2;
    int sum = 0;
    for(int i = 0; i< arr.Length; i++)
    {
        sum = sum + arr[i];
    }

    return sumOf10 - sum;
}

void findSubArrayWithGivenSum(int[] arr)
{
    int givenSum = 15;
    int startingIndex = -1;
    int endingIndex = -1;

    for (int i =0; i< arr.Length -1; i++)
    {
        int sumForCurrentIndex = arr[i];
        for(int j= i+ 1; j < arr.Length; j++)
        {
            sumForCurrentIndex = sumForCurrentIndex + arr[j];
            if(sumForCurrentIndex > givenSum)
            {
                break;
            }
            else if (sumForCurrentIndex == givenSum)
            {
                startingIndex = i;
                endingIndex = j;
            }
        }
    }

    Console.WriteLine("starting index " + startingIndex);
    Console.WriteLine("starting index " + endingIndex);
}

void getArraysWithSumZero(int[] arr)
{
    int sum= 0;

    for(int i = 0; i < arr.Length-1; i++)
    {
        sum = arr[i];
        for (int j = i + 1; j < arr.Length; j++)
        {
            sum += arr[j];
            if(sum == 0)
            {
                Console.Write("Found index " + i + " " + j);
            }
        }
    }
}