int number;
Console.WriteLine("Введите целое число");
while (!int.TryParse(Console.ReadLine(), out number) || number > -1000 || number < -9999)
    Console.WriteLine("Неверный ввод. Введите целое число");

Console.WriteLine(-number % 1000 / 100);