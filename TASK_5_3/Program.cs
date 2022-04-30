// Для ясности примем что нечетные позиции элементов в массиве это нечетные позиции массива считая с 1(0-ой элемент массива). (1,3,5....)
int n = 6;
var arr = new double[n];

FillRandomArray(arr, -50, 50, 1);
Console.Write("Array of " + n + " elements: ");
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine($"Difference: {FindExtemums(arr)[0] - FindExtemums(arr)[1]}");




void FillRandomArray(double[] arr, int lBound, int rBound, int dec)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lBound * 10 * dec, rBound * 10 * dec + 1) / 10.0 / dec;
    }
}

double[] FindExtemums(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    foreach (var val in arr)
    {
        if (max < val) max = val;
        else if (min > val) min = val;
    }
    return new double[] {max, min};
}