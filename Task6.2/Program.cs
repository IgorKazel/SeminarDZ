double NumberEntry(string message)
{
    Console.WriteLine(message);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

bool CheckLines(double B1, double K1, double B2, double K2)
{
    if (K1 == K2 && B1 == B2)
    {
        Console.WriteLine("Линии полностью совпадают");
        return false;
    }
    else if (K1 == K2)
    {
        Console.WriteLine("Линии параллельны");
        return false;
    }
    else
    {
        return true;
    }
}

double[] LinesCrossing(double B1, double K1, double B2, double K2)
{
    double X = (B2 - B1) / (K1 - K2);
    double Y = K1 * X + B1;
    double[] crossPoint = { X, Y };
    return crossPoint;
}

Console.WriteLine("Существует две прямые заданные уравнением - y = k * x + b");
double b1 = NumberEntry("Введите значение b для первой линии");
double k1 = NumberEntry("Введите значение k для первой линии");
double b2 = NumberEntry("Введите значение b для второй линии");
double k2 = NumberEntry("Введите значение k для второй линии");
if (CheckLines(b1, k1, b2, k2))
{
    double[] cross = LinesCrossing(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты ({cross[0]}; {cross[1]})");
}
