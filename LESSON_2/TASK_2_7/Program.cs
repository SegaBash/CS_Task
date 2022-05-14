// Предположим, что заказчик хочет введения значений из области рациональных чисел. Для интереса.
double number;
Console.WriteLine("Введите число");
while (!double.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Неверный ввод. Введите число, пожалуйста");

double absNum = Math.Abs(number);
//if (Math.Abs(number)>=100) Console.WriteLine(number.ToString().Replace("-","")[2]);
if (absNum >= 100) Console.WriteLine(Find3Digit(absNum));
else Console.WriteLine("третьей цифры нет");


int Find3Digit(double num)
{
    int digit3 = (int)Math.Log10(num) + 1;
    return (int)(num / Math.Pow(10, digit3 - 3) % 10);
}