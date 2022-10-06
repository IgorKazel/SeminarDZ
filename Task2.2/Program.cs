int a = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число - {a}");
int a1 = a / 100;
int a3 = a % 10;
int a13 = a1 * 10 + a3;
Console.WriteLine($"Данное число без второй цифры - {a13}");
