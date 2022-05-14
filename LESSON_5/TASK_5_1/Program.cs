int n = 5;
var arr = new int[n];

FillRandomArray(arr, 100, 999);
Console.Write("Array of " + n + " elements: ");
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.Write("Number of even elements: ");
Console.WriteLine(GetEvenConunt(arr));



void FillRandomArray(int[] arr, int lBound, int rBound)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lBound, rBound + 1);
    }
}

int GetEvenConunt(int[] arr)
{
    int even = 0;
    foreach (var val in arr)
        if (val % 2 == 0) even += 1;
    return even;
}