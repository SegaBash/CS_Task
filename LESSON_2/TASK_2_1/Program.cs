int number = new Random().Next(10, 100);
Console.WriteLine(number);
Console.WriteLine(MaxDigitOfNumber(number));

int MaxDigitOfNumber(int num)
{
    int digit1 = num / 10;
    int digit2 = num % 10;
    return digit1 > digit2 ? digit1 : digit2;
}