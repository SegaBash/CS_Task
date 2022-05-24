int rows = 4;
int columns = 4;
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

void FillLine(int[,] arr, int[] pos, int[] dirVector, int offset, int count, int countMax)
{
    count++;
    int limit = dirVector[0] != 0 ? arr.GetLength(0) - offset*2 - 1 : arr.GetLength(1) - offset*2 - 1;
    for (int i = 0; i < limit; i++)
    {
        arr[pos[0], pos[1]] = count;
        pos[0] += dirVector[0];
        pos[1] += dirVector[1];
    }
    if (count % 4 == 0)
    {
        offset++;
        pos[0] += -dirVector[0] + dirVector[1];
        pos[1] += -dirVector[1] - dirVector[0];
    }
    int tmp = dirVector[0];
    dirVector[0] = dirVector[1];
    dirVector[1] = -tmp;
    if (count <= countMax) FillLine(arr, pos, dirVector, offset, count, countMax);
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