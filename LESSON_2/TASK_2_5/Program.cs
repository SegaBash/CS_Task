// Примем что ввод задачи происходит в множестве целых чисел
int num1, num2;
Console.WriteLine("Введите первое целое число");
while (!int.TryParse(Console.ReadLine(), out num1))
    Console.WriteLine("Неверный ввод. Введите первое целое число");
Console.WriteLine("Введите второе целое число");
while (!int.TryParse(Console.ReadLine(), out num2))
    Console.WriteLine("Неверный ввод. Введите второе целое число");

if(num1*num1 == num2 || num1 == num2*num2) 
Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
