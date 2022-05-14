int[,] inputArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 1, 2, 3 }, { 1, 2, 3 } };
int[] newArrayValue, newArrayCount;
Console.WriteLine("Входящий массив: ");
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
        Console.Write(inputArray[i, j] + " ");
    Console.WriteLine();
}
int[] workArray = Get1DimArray(inputArray);
SortArray(workArray);
GetValueAndCount(out newArrayValue, out newArrayCount, workArray);
Console.WriteLine("Словарь: ");
PrintDictionary(newArrayValue, newArrayCount);

int[] Get1DimArray(int[,] array2D)
{
    int length = array2D.GetLength(0) * array2D.GetLength(1);
    int[] array1D = new int[length];
    int k = 0;
    foreach (var item in array2D)
    {
        array1D[k] = item;
        k++;
    }
    return array1D;
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        bool swap = false;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[minPos] > array[j]) minPos = j; swap = true;
        }
        if (swap)
        {
            int temp = array[i];
            array[i] = array[minPos];
            array[minPos] = temp;
        }
    }
}

void GetValueAndCount(out int[] arrayValue, out int[] arrayCount, int[] array)
{
    arrayValue = new int[array.Length];
    arrayCount = new int[array.Length];
    var last = arrayValue[0] = array[0];
    arrayCount[0] = 1;
    int k = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == arrayValue[k]) arrayCount[k]++;
        else
        {
            k = k + 1;
            arrayValue[k] = array[i];
            arrayCount[k] = 1;
        }
    }
    Array.Resize(ref arrayValue, k + 1);
    Array.Resize(ref arrayCount, k + 1);
}

void PrintDictionary(int[] value, int[] count)
{
    for (int i = 0; i < value.Length; i++)
    {
        Console.WriteLine($"Значение {value[i]} количество {count[i]}");
    }

}
