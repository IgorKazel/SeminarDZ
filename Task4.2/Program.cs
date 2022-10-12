int SumDigits(int number)
{
    if (number < 0)
    {
        number = -number;
    }
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sumDig = SumDigits(a);
Console.WriteLine($"Сумма цифр числа {a} равна {sumDig}");
