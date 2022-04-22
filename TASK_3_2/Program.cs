var a = new double[2];
var b = new double[2];
//a = new double[] { 3, 6 };
//b = new double[] { 2, 1 };
///*
Console.WriteLine("Введите абсциссу первой точки");
while (!double.TryParse(Console.ReadLine(), out a[0]))
    Console.WriteLine("Неверный ввод. Введите абсциссу первой точки");
Console.WriteLine("Введите ординату первой точки");
while (!double.TryParse(Console.ReadLine(), out a[1]))
    Console.WriteLine("Неверный ввод. Введите ординату первой точки");
Console.WriteLine("Введите абсциссу второй точки");
while (!double.TryParse(Console.ReadLine(), out b[0]))
    Console.WriteLine("Неверный ввод. Введите абсциссу второй точки");
Console.WriteLine("Введите ординату второй точки");
while (!double.TryParse(Console.ReadLine(), out b[1]))
    Console.WriteLine("Неверный ввод. Введите ординату второй точки");
//*/
Console.WriteLine(FindDistance(a, b));

double FindDistance(double[] a, double[] b)
{
    double distance = Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2));
    return Math.Floor(distance*100)/100;
}
