int[] CreateArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int SearchSecondMax (int[] array)
{
    int max = array[0];
    int secondMax = 0;
    if (max > array[1])
    {
        secondMax = array[1];
    }
    else
    {
        secondMax = max;
        max = array[1];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        else if (array[i] > secondMax & array[i] != max)
        {
            secondMax = array[i];
        }
    }
    return secondMax;
}

Console.WriteLine("Случайный массив из 10 чисел:");
int[] arr = CreateArray();
int secMax = SearchSecondMax(arr);
Console.WriteLine($"Второй максимум из данного массива {secMax}");
