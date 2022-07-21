// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//first sort the array elements
// 1 2 3 4 5 6 7 -> 1 < 3 > 2 < 5 > 4 < 7 > 6 < 9 > 8
//for every even number index fill 

int[] arr = new int[10] { 1, 3, 14, 5, 16, 7, 2, 9, 20, 10 };
arr = arr.OrderBy(x => x).ToArray();
int[] arr2 = new int[10];
arr2[0] = arr[0];
for(int i = 1; i < arr.Length; i++)
{
    if (i == arr.Length - 1)
    {
        arr2[i] = arr[i];
    }
    else if (i%2 == 0)
    {
        arr2[i - 1] = arr[i];
    }
    else
    {
        arr2[i + 1] = arr[i];
    }
   
}

for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}

