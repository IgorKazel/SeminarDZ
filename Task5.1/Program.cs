int[] CreateArray(int length, int minLimit, int maxLimit)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minLimit, maxLimit + 1);
    }
    return array;
}

void PrintArray(int[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int QuantityEven(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

int[] arr = CreateArray(4, 100, 999);
PrintArray(arr, "Случайный массив положительных трехзначных чисел:");
int qty = QuantityEven(arr);
Console.WriteLine($"Количество четных чисел в массиве - {qty}");
