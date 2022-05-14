double x, y;
Console.WriteLine("Введите координату X");
while (!double.TryParse(Console.ReadLine(), out x) || x == 0)
    Console.WriteLine("Неверный ввод. Введите координату X");
Console.WriteLine("Введите координату Y");
while (!double.TryParse(Console.ReadLine(), out y) || y == 0)
    Console.WriteLine("Неверный ввод. Введите координату Y");

var point = new double[] { x, y };
Console.WriteLine(GetQuater(point));


string GetQuater(double[] point)
{
    if (point[0] > 0)
    {
        if (point[1] > 0) return "1 четверть";
        else return "4 четверть";
    }
    else
    {
        if (point[1] > 0) return "2 четверть";
        else return "3 четверть";
    }
}