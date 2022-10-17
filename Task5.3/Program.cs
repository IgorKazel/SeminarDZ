void PrintArray(double[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array [0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double[] arr = {3.1, 7.4, 22.3, 2.2, 8.2};
PrintArray(arr, "Массив вещественных чисел:");
double max = FindMax(arr);
double min = FindMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами - {max - min}");
