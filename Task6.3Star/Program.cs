int[,] FillArray()
{
    int[,] array = new int[2,3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);  
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
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}

int SumMaxNumberLine(int[,] array)
{
    int sum = 0;
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        max = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
           if (array[i,j] > max)
           {
            max = array[i,j];
           }
        }
        sum += max;
    }
    return sum;
}

int SumMinNumberColumn(int[,] array)
{
    int sum = 0;
    int min = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min = array[0,j];
        for (int i = 1; i < array.GetLength(0); i++)
        {
           if (array[i,j] < min)
           {
            min = array[i,j];
           }
        }
        sum += min;
    }
    return sum;
}

int[,] arr = FillArray();
PrintArray(arr, "Случайный массив:");
int sumLine = SumMaxNumberLine(arr);
Console.WriteLine($"Сумма максимальных чисел в каждой строке - {sumLine}");
int sumColumn = SumMinNumberColumn(arr);
Console.WriteLine($"Сумма минимальных чисел в каждом столбце - {sumColumn}");
int result = sumLine - sumColumn;
Console.WriteLine($"Разница максимальных чисел в каждой строке и минимальных чисел в каждом столбце - {result}");
