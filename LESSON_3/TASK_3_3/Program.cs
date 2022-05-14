int N;
Console.WriteLine("Введите целое число > 1");
while (!int.TryParse(Console.ReadLine(), out N) || N <= 1)
    Console.WriteLine("Неверный ввод. Введите целое число > 1");

Console.WriteLine(String.Join(", ", GetSquares(N)));


int[] GetSquares(int n)
{
    var arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = (i + 1) * (i + 1);
    }
    return arr;
}