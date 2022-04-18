// Примем, что вводимые числа принадлежат множеству вещественных чисел, вариант с равенством отдельно не рассматриваем
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

double max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine(max);