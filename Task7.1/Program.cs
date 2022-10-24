double[,] FillArray(int line, int column)
{
    double[,] array = new double[line,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-9,10) + new Random().Next(-9,10)/10.0;  
        }
    }
    return array;
}

void PrintArray(double[,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1}\t");  
        }
        Console.WriteLine();
    }
}

double[,] arr = FillArray(3,4);
PrintArray(arr, "Случайный массив вещественных чисел:");
