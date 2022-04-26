int number;
Console.WriteLine("Введите целое пятизначное число");
while (!int.TryParse(Console.ReadLine(), out number) || number < 10000 || number > 99999)
    Console.WriteLine("Неверный ввод. Введите целое пятизначное число.");

if (IsPalindrome(number)) Console.WriteLine("ДА");
else Console.WriteLine("НЕТ");


bool IsPalindrome(int num)
{
    return num/1000==num%10*10+num % 100 / 10;
}