Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int B = Convert.ToInt32(Console.ReadLine());
if (B >= 0)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result = result * A;
    }
    Console.WriteLine($"Число {A} в степени {B} равно {result}");
}
else
{
    Console.WriteLine($"Число {B} не натуральное");
}
