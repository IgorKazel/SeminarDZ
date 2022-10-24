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

void PrintArray(double[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f2}\t");
    }
    Console.WriteLine();
}

void PrintTwoDimensionalArray(int[,] array, string message)
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

double[] AverageEachColumn(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = (double)sum / array.GetLength(0);
        sum = 0;
    }
    return result;
}

int[,] arr = FillArray(3, 4);
PrintTwoDimensionalArray(arr, "Случайный массив:");
double[] result = AverageEachColumn(arr);
PrintArray(result, "Среднее арифметическое каждого столбца:");
