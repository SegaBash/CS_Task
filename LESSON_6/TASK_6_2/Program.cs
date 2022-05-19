int[,] matrixA = CreateRandomMAtrix(3, 5, 10);
int[,] matrixB = CreateRandomMAtrix(5, 2, 10);
Console.WriteLine("Первая матрица:\n");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица:\n");
PrintMatrix(matrixB);
Console.WriteLine();
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    System.Console.WriteLine(
        "Умножение невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй");
    Environment.Exit(0);
}
Console.WriteLine("Произведение матриц:\n");
int[,] matrixC = GetMAtrixProduct(matrixA, matrixB);
PrintMatrix(matrixC);
Console.WriteLine();

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

int[,] GetMAtrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}