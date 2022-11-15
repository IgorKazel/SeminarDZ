int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumIntervalNumber(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    return start + SumIntervalNumber(start + 1, end);
}

int m = NumberEntry("Введите первое натуральное число");
int n = NumberEntry("Введите второе натуральное число");
int sumInterval = 0;
if (m < n)
{
    sumInterval = SumIntervalNumber(m, n);
}
else
{
    sumInterval = SumIntervalNumber(n, m);
}
Console.WriteLine($"Сумма всех натуральных чисел в промежутке от {m} до {n} - {sumInterval}");
