// Принимаем что задача решается в 
Console.WriteLine("Введите целое число A > 1");
//while (!int.TryParse(Console.ReadLine(), out A) || A <= 1)
//    Console.WriteLine("Неверный ввод. Введите целое число A > 1");
int input;
while (RepeatInput(Console.ReadLine()))
    Console.WriteLine("Неверный ввод. Введите целое число A > 1");
int A = input;
int sum = A * (A + 1) / 2;
if (sum == GetSumCycle(A))
Console.WriteLine($"Сумма определенно равна {sum}");
else Console.WriteLine("Творится что-то невероятное");


bool RepeatInput(string? inString)
{
    bool condition1 = int.TryParse(inString, out input);
    bool condition2 = input > 1;
    return !(condition1 && condition2);
}

int GetSumCycle(int n)
{
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
return sum;
}