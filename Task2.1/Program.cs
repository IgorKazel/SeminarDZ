Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 & a < 1000)
{
    int number2 = a / 10 % 10;
    Console.WriteLine($"Вторая цифра числа {a} - {number2}");
}
else
{
    Console.WriteLine($"Число {a} - не трехзначное");
}
