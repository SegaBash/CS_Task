int N;
Console.WriteLine("Введите целое число, больше 1");
while (!int.TryParse(Console.ReadLine(), out N) || !(N > 1))
    Console.WriteLine("Неверный ввод. Введите целое число, больше 1");

for (int k = 2; k <= N; k += 2)
{
    if (k!=2) Console.Write(", ");
    Console.Write(k);
}