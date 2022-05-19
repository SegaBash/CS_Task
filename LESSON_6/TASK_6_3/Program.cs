int rows = 15;
int maxNumber = GetValue(rows - 1, (rows - 1) / 2);
int maxSize = (int)Math.Log(maxNumber, 10) + 1;
string[,] pascal = new string[rows, rows];

FillSpace(pascal,maxSize);
FillValue(pascal);
PrintPascal(pascal);
//формула для подсчета элемента треугольника
int GetValue(int n, int m)
{
    int res = 1;
    for (int i = n; i > 1; i--)
    {
        if (i > m) res *= i;
        if (i <= n - m) res /= i;
    }
    return res;
}
// Заполняет массив(половина треугольника) пробелами
void FillSpace(string[,] array, int maxSize)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new string(' ', maxSize);
        }
    }
}
// Заполняет массив(половина треугольника) значениями
void FillValue(string[,] array)
{
    int len = array.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        for (int j = len - 1 - i % 2; j >= len - 1 - i; j -= 2)
        {
            string strValue = GetValue(i, (i + j - len + 1) / 2).ToString();
            // Условие заполнения треугольника только нечетными значениями
            //if(GetPosition(i, (i + j - len + 1) / 2) % 2 == 0) strValue = new string(' ', maxSize); 
            int offset = (maxSize - strValue.Length) / 2;
            array[i, j] = new string(' ', offset) + strValue + new string(' ', maxSize - strValue.Length - offset);
        }
    }
}
// Печатает полный(обе половины) треугольник
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