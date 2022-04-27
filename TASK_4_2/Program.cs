double a;
int b;
Console.WriteLine("Введите основание степени");
while (!double.TryParse(Console.ReadLine(), out a))
    Console.WriteLine("Неверный ввод. Введите основание степени");
Console.WriteLine("Введите натуральный показатель степени");
while (!int.TryParse(Console.ReadLine(), out b) || b < 1)
    Console.WriteLine("Неверный ввод. Введите натуральный показатель степени");

Console.WriteLine(GetNaturalDegree(a, b));


double GetNaturalDegree(double a, int b)
{
    double result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}