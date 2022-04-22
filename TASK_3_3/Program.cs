int N;
Console.WriteLine("Введите целое число > 1");
while (!int.TryParse(Console.ReadLine(), out N) || N <= 1)
    Console.WriteLine("Неверный ввод. Введите целое число > 1");

for (int i = 1; i <= N; i++)
{
    if (i!=1) Console.Write(", ");
    Console.Write(i * i);
}