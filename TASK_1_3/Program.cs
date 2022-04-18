
double number;
Console.WriteLine("Введите число");
while (!double.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Введите ЧИСЛО");

if (number % 2 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
