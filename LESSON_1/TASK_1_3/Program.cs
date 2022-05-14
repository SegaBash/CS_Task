// четность/нечетность актуально в множестве целых чисел, работаем с ним
int number;
Console.WriteLine("Введите целое число");
while (!int.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Введите целое ЧИСЛО");

if (number % 2 == 0) Console.WriteLine("да");
else Console.WriteLine("нет");
