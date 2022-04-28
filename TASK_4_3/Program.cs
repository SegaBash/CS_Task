//принимаем область вводимых значений - множество целых чисел
int number;
Console.WriteLine("Ведите целое число");
while (!int.TryParse(Console.ReadLine(), out number))
    Console.WriteLine("Неверный ввод. Введите целое число");

number = Math.Abs(number);
Console.WriteLine(GetDigitSum(number));


int GetDigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}