int number;
Console.WriteLine("Введите целое число");
while(!int.TryParse(Console.ReadLine(),out number))
Console.WriteLine("Неверный ввод. Введите целое число");

if(number%7==0&&number%23==0) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");
