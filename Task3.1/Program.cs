Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 9999 & a < 100000)
{
    if (a / 10000 == a % 10 & a / 1000 % 10 == a / 10 % 10)     // Сравниванем 1-ую цифру с 5-ой и 2-ую с 4-ой
    {
        Console.WriteLine($"Число {a} - палендром");
    }
    else
    {
        Console.WriteLine($"Число {a} - не палендром");
    }  
}
else
{
    Console.WriteLine($"Число {a} - не пятизначное");
}
