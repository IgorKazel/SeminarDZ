Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a % 2;
if (ost == 0)
{
    Console.WriteLine($"Число {a} - четное");
}
else
{
    Console.WriteLine($"Число {a} - нечетное");
}
