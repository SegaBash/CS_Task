int[,,] matrix = CreateRandomMAtrix(3, 5, 6, 100);
PrintMatrix(matrix);

int[,,] CreateRandomMAtrix(int dim1, int dim2, int dim3, int limit)
{
    List<int> originalValue = new List<int>();
    int[,,] matrix = new int[dim1, dim2, dim3];
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                while (true)
                {
                    matrix[i, j, k] = new Random().Next(0, limit);
                    if (!originalValue.Contains(matrix[i, j, k])) { originalValue.Add(matrix[i, j, k]); break; }
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.WriteLine($"Element [{i},{j},{k}] = {matrix[i, j, k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
