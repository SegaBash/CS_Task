int N;
Console.WriteLine("Введите целое число, больше 1");
while (!int.TryParse(Console.ReadLine(), out N) || !(N > 1))
    Console.WriteLine("Неверный ввод. Введите целое число, больше 1");

for (int k = -N; k <= N; k++)
{
    if (k != -N) Console.Write(", ");
    Console.Write(k);
}