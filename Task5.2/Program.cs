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

int SumUnevenPosition(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
       Sum += array[i];
    }
    return Sum;
}

int[] arr = CreateArray(4, -99, 99);
PrintArray(arr, "Массив случайных чисел:");
int sum = SumUnevenPosition(arr);
Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях - {sum}");
