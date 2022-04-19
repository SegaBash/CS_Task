Console.WriteLine("Введите целое трехзначное число");
while (!int.TryParse(Console.ReadLine(), out int number) || number < 100 || number > 999)
    Console.WriteLine("Неверный ввод. Введите целое трехзначное число.");



