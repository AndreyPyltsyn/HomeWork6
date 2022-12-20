//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите число b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2");
double k2 = double.Parse(Console.ReadLine()!);

double pointX = CrossPointX(b1, k1, b2, k2);
double pointY = CrossPointY(k1, pointX, b1);
Console.WriteLine("(" + pointX + ";" + pointY + ")");




double CrossPointX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double CrossPointY(double k1, double x, double b1)
{
    double y = k1 * x + b1;
    return y;
}