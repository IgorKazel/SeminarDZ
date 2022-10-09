Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if (N>=1)
{
    Console.WriteLine($"Кубы чисел от 1 до {N}:");
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
else
{
    Console.WriteLine("Введенное число меньше 1");
}
