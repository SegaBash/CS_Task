int rows = 15;
int maxNumber = GetPosition(rows - 1, (rows - 1) / 2);
int maxSize = (int)Math.Log(maxNumber, 10) + 1;
string[,] pascal = new string[rows, rows];

FillSpace(pascal);
FillValue(pascal);
PrintPascal(pascal);

int GetPosition(int n, int m)
{
    int res = 1;
    for (int i = n; i > 1; i--)
    {
        if (i > m) res *= i;
        if (i <= n - m) res /= i;
    }
    return res;
}

void FillSpace(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new string(' ', maxSize);
        }
    }
}

void FillValue(string[,] array)
{
    int len = array.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        for (int j = len - 1 - i % 2; j >= len - 1 - i; j -= 2)
        {
            string strValue = GetPosition(i, (i + j - len + 1) / 2).ToString();
            // Условие заполнения треугольника только нечетными значениями
            //if(GetPosition(i, (i + j - len + 1) / 2) % 2 == 0) strValue = new string(' ', maxSize); 
            int offset = (maxSize - strValue.Length) / 2;
            array[i, j] = new string(' ', offset) + strValue + new string(' ', maxSize - strValue.Length - offset);
        }
    }
}

void PrintPascal(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        for (int j = array.GetLength(1) - 2; j >= 0; j--)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}