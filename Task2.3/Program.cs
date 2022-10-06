Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int a3 = a;
if (a > 99)
{
    while (a3 > 999)
    {
        a3 = a3 / 10;
    }
    a3 = a3 % 10;
    Console.WriteLine($"Третья цифра числа {a} - {a3}");
}
else
{
    Console.WriteLine($"У числа {a} - нет третьей цифры");
}
