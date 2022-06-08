int[,] matrix = CreateRandomMAtrix(4, 4, 10);
Console.WriteLine(" Сгенерированная матрица:\n");
PrintMatrix(matrix);
int[,] sortedMatrix = CreateSortedMatrix(matrix);
if (sortedMatrix.GetLength(0) != sortedMatrix.GetLength(1)) { Console.WriteLine("\n Ничего не получится!"); Environment.Exit(0); }
Console.WriteLine("\n Измененная матрица:\n");
PrintMatrix(sortedMatrix);


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

int[,] CreateSortedMatrix(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            int maxPos = j;
            bool swap = false;
            for (int k = j + 1; k < columns; k++)
            {
                if (arr[i,maxPos] < arr[i,k]) maxPos = k; swap = true;
            }
            if (swap)
            {
                int temp = arr[i,j];
                arr[i,j] = arr[i,maxPos];
                arr[i,maxPos] = temp;
            }
        }
    }
    return arr;
}
