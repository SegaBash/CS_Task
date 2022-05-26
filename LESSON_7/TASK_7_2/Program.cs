int[,] matrix = CreateRandomMAtrix(7, 6, 10);
Console.WriteLine(" Старая матрица:\n");
PrintMatrix(matrix);
int[,] trimmedMatrix = CreateTrimmedMAtrix(matrix, GetMinIndexLists(matrix)[0], GetMinIndexLists(matrix)[1]);
if ((trimmedMatrix.GetLength(0) + trimmedMatrix.GetLength(1)) == 0) {Console.WriteLine("\n Новая матрица погибла"); Environment.Exit(0);}
Console.WriteLine("\n Новая матрица:\n");
PrintMatrix(trimmedMatrix);


List<List<int>> GetMinIndexLists(int[,] arr)
{
    int min = arr[0, 0];
    List<int> minRowList = new List<int>();
    List<int> minColumnList = new List<int>();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minRowList.Clear();
                minRowList.Add(i);
                minColumnList.Clear();
                minColumnList.Add(j);
            }
            else if (arr[i, j] == min)
            {
                if (!minRowList.Contains(i)) minRowList.Add(i);
                if (!minColumnList.Contains(j)) minColumnList.Add(j);
            }
        }
    }
    return new List<List<int>> { minRowList, minColumnList };
}


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

int[,] CreateTrimmedMAtrix(int[,] arr, List<int> rows, List<int> columns)
{
    int n = 0;
    int m = 0;
    int[,] matrix;
    if (arr.GetLength(0) == rows.Count || arr.GetLength(0) == columns.Count) return matrix = new int[0, 0];
    matrix = new int[arr.GetLength(0) - rows.Count, arr.GetLength(1) - columns.Count];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (rows.Contains(i)) continue;
        m = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (columns.Contains(j)) continue;
            matrix[n, m] = arr[i, j];
            m++;
        }
        n++;
    }

    return matrix;
}
