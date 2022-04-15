double num1, num2, num3;
Console.WriteLine("Введите первое число");
while (!double.TryParse(Console.ReadLine(), out num1))
    Console.WriteLine("Введите первое ЧИСЛО");
Console.WriteLine("Введите второе число");
while (!double.TryParse(Console.ReadLine(), out num2))
    Console.WriteLine("Введите второе ЧИСЛО");
Console.WriteLine("Введите третье число");
while (!double.TryParse(Console.ReadLine(), out num3))
    Console.WriteLine("Введите третье ЧИСЛО");

if (num1 > num2)
{
    if (num1 > num3)
        Console.WriteLine(num1);
    else
        Console.WriteLine(num3);
}
else
{
    if (num2 > num3)
        Console.WriteLine(num2);
    else
        Console.WriteLine(num3);
}