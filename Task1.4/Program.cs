Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (count <= N)
{
    Console.WriteLine($"Все четные числа от 1 до {N}:");
}
else
{
    Console.WriteLine("Введенное число меньше или равно 1");
}
while (count <= N)
{
    Console.Write($"{count} ");
    count = count + 2;
}
