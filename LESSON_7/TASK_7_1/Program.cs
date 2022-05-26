int rows = 8;
int columns = 6;
int[,] spiralArray = new int[rows, columns];
FillSpiral(spiralArray);
PrintArray(spiralArray);

void FillSpiral(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int countMax = rows > columns ? columns * 2 : rows * 2 - 1;
    FillLine(arr, new int[] { 0, 0 }, new int[] { 0, 1 }, 0, 0, countMax);
}

void FillLine(int[,] arr, int[] pos, int[] dirVector, int count, int countLine, int countMax)
{
    countLine++;
    int limit = dirVector[0] != 0 ? arr.GetLength(0) - ((countLine - 1) / 4 ) * 2 - 1 : arr.GetLength(1) - ((countLine - 1) / 4 ) * 2 - 1;
    for (int i = 0; i < limit; i++)
    {
        count++;
        arr[pos[0], pos[1]] = count;
        pos[0] += dirVector[0];
        pos[1] += dirVector[1];
    }
    if (countLine % 4 == 0)
    {
        pos[0] += -dirVector[0] + dirVector[1];
        pos[1] += -dirVector[1] - dirVector[0];
    }
    int tmp = dirVector[0];
    dirVector[0] = dirVector[1];
    dirVector[1] = -tmp;
    if (countLine <= countMax) FillLine(arr, pos, dirVector, count, countLine, countMax);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j != 0) Console.Write(" ");
            Console.Write($"{array[i, j]:D2}");
        }
        Console.WriteLine("|");
    }
}