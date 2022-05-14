int number;
Console.WriteLine("Введите цифру дня недели");
while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 7)
    Console.WriteLine("Неверный ввод. Введите цифру дня недели.");

if (number > 5) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
