Console.WriteLine("Введите цифру, обозначающую день недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 8)
{
    if (a > 5)
    {
        Console.WriteLine($"{a} день недели - выходной");
    }
    else
    {
        Console.WriteLine($"{a} день недели - будний");
    }
}
else
{
    Console.WriteLine($"Число {a} не обозначает день недели. В неделе 7 дней.");
}
