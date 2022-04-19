int number;
Console.WriteLine("Введите целое трехзначное число");
while (!int.TryParse(Console.ReadLine(), out number) || number > 999 || number < 100)
    Console.WriteLine("Неверный ввод. Введите целое трехзначное число");

//Console.WriteLine(number.ToString()[2]);
Console.WriteLine(number % 10);
