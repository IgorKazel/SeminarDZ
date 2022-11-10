int[,] FillArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumEachLine(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int MinNumberIndex(int[] array)
{
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[indexMin] > array[i])
        {
            indexMin = i;
        }
    }
    return indexMin + 1;
}

int[,] arr = FillArray(4, 3);
PrintArray(arr, "Случайный массив:");
int[] sumInLines = SumEachLine(arr);
int index = MinNumberIndex(sumInLines);
Console.WriteLine($"Наименьшая сумма элементов в строке {index}");
