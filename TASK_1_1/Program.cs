//для данной задачи примем, что числа принадлежат множеству вещественных чисел, вариант с равенством чисел имеет свой вывод. 
double num1, num2;
Console.WriteLine("Введите первое число");
while (!double.TryParse(Console.ReadLine(), out num1))
    Console.WriteLine("Введите первое ЧИСЛО");
Console.WriteLine("Введите второе число");
while (!double.TryParse(Console.ReadLine(), out num2))
    Console.WriteLine("Введите второе ЧИСЛО");


if (num1 == num2)
    Console.WriteLine("max = min = " + num1);
else
{
    if (num1 > num2)
        Console.WriteLine("max = " + num1);
    else
        Console.WriteLine("max = " + num2);
}