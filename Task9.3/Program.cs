int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckNumbers(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return true;
    }
    return false;
}

int AkkermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AkkermannFunction(m - 1, 1);
    }
    return AkkermannFunction(m - 1, AkkermannFunction(m, n - 1));
}

int m = NumberEntry("Введите натуральное число m:");
int n = NumberEntry("Введите натуральное число n:");
if (CheckNumbers(m, n))
{
    Console.WriteLine("Оба числа должны быть неотрицательными");
    return;
}
int result = AkkermannFunction(m, n);
Console.WriteLine($"Функция Аккермана: A({m},{n}) = {result}");
