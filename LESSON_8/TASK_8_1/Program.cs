int[,] matrix = CreateRandomMAtrix(3, 4, 10);
Console.WriteLine(" Сгенерированная матрица:\n");
PrintMatrix(matrix);
int[,] swappedMatrix = CreateSwappedMatrix(matrix, 0, matrix.GetLength(0)-1);
if (swappedMatrix.GetLength(0) < 2) { Console.WriteLine("\n Мало строк!"); Environment.Exit(0); }
Console.WriteLine("\n Измененная матрица:\n");
PrintMatrix(swappedMatrix);


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

int[,] CreateSwappedMatrix(int[,] arr, int row1, int row2)
{
    int rowNumber;
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,] swappedArray = new int[rows, columns];
for (int i = 0; i < rows; i++)
    {
        if(i == row1) rowNumber = row2;
        else if (i == row2) rowNumber = row1;
        else rowNumber = i;
        for (int j = 0; j < columns; j++)
        {
            swappedArray[i,j] = arr[rowNumber,j];
        }
    }
    return swappedArray;
}