// Предположим, что заказчик хочет введения значений из области рациональных чисел
double number;
Console.WriteLine("Введите число");
while (!double.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Неверный ввод. Введите число, пожалуйста");
int digit3 = (int)(Math.Abs(number)/100);
Console.WriteLine(digit3);