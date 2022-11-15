int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintEvenNumber (int start, int end)
{
    if (start % 2 != 0)
    {
        start += 1;
    }
    Console.Write($"{start} ");
    start += 2;
    if (start <= end)
    {
        PrintEvenNumber(start, end);
    }
}

int m = NumberEntry("Введите первое натуральное число");
int n = NumberEntry("Введите второе натуральное число");
Console.WriteLine($"Все четные натуральные числа в промежутке от {m} до {n}: ");
if (m < n)
{
    PrintEvenNumber(m, n);
}
else
{
    PrintEvenNumber(n, m);
}
