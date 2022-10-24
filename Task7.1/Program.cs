int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] FillArray(int line, int column)
{
    double[,] array = new double[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 100) / 10.0;
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
            Console.Write($"{array[i, j]:f1}\t");
        }
        Console.WriteLine();
    }
}

int m = NumberEntry("Задайте количество строк в массиве");
int n = NumberEntry("Задайте количество столбцов в массиве");
if (m < 1 || n < 1)
{
    Console.WriteLine("Количество строк и столбцов в массиве не может быть меньше 1");
    return;
}
double[,] arr = FillArray(m, n);
PrintArray(arr, "Случайный массив вещественных чисел:");
