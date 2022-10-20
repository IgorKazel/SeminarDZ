int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FillArray(int length)
{
    Console.WriteLine("Введите числа");
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int m = NumberEntry("Введите количество чисел, которое собираетесь вводить");
if (m < 1)
{
    Console.WriteLine("Количество вводимых чисел не может быть меньше 1");
    return;
}
int[] arr = FillArray(m);
int qty = PositiveNumber(arr);
Console.WriteLine($"Среди введенных вами чисел положительными являются - {qty}");
