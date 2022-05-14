// примем в условии задачи что первое введенное число должно быть кратно второму. чтобы было соответствие премеру выполнения программы.
int num1, num2;
Console.WriteLine("Введите первое целое число");
while (!int.TryParse(Console.ReadLine(), out num1))
    Console.WriteLine("Неверный ввод. Введите первое целое число");
Console.WriteLine("Введите второе целое число");
while (!int.TryParse(Console.ReadLine(), out num2))
    Console.WriteLine("Неверный ввод. Введите второе целое число");

if (FindReminder(num1, num2) == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток - {FindReminder(num1, num2)}");


int FindReminder(int num1, int num2)
{
    return num1 % num2;
}
//Глупый конечно метод получился, но для практики и такой сойдет.