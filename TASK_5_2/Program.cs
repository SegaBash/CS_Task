// Для ясности примем что нечетные позиции элементов в массиве это нечетные позиции массива считая с 1(0-ой элемент массива). (1,3,5....)
int n = 5;
var arr = new int[6];

FillRandomArray(arr, 10, 99);
Console.Write("Array of " + n + " elements: ");
Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.Write("Sum of odd position elements: ");
Console.WriteLine(GetOddPosSum(arr));



void FillRandomArray(int[] arr, int lBound, int rBound)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(lBound, rBound + 1);
    }
}

int GetOddPosSum(int[] arr)
{
    int sum = 0;
   for (int i = 0; i < arr.Length; i++)
   {
            if (i % 2 == 0) sum += arr[i];
   }
    return sum;
}