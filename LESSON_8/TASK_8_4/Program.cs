int[,] matrix = CreateRandomMAtrix(5, 3, 10);
Console.WriteLine(" Сгенерированная матрица:\n");
PrintMatrix(matrix);
Console.WriteLine($"\n Наименьшая сумма элементов - {FindMinSumRow(matrix)} строка ");


int[,] CreateRandomMAtrix(int rows, int columns, int limit)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, limit);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != 0) Console.Write(" ");
            Console.Write($"{matrix[i, j]:D2}");
        }
        Console.WriteLine("|");
    }
}

int FindMinSumRow(int[,] arr)
{
    int minSumRow = 0;
    int minSumRowNumber = 0;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < columns; j++)
        {
            rowSum += arr[i, j];
        }
        if (i == 0) minSumRow = rowSum;
        if (minSumRow > rowSum)
        {
            minSumRow = rowSum;
            minSumRowNumber = i;
        }
    }
    return minSumRowNumber;
}
