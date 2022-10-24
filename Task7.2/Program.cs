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

int NumberEntry(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintElement(int[,] array, int line, int column)
{
    if (line > 0 && line <= array.GetLength(0) && column > 0 && column <= array.GetLength(1))
    {
        Console.WriteLine($"Значение выбранного элемента - {array[line - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine($"Нет такого элемента");
    }
}

int[,] arr = FillArray(5, 5);
PrintArray(arr, "Случайный массив:");
int line = NumberEntry("Введите строку элемента:");
int column = NumberEntry("Введите столбец элемента:");
PrintElement(arr, line, column);
