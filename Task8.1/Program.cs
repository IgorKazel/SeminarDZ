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

int[,] OrderingNumbersInLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1)-1; k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if(array[i,j] < array[i,j+1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                }
            }    
        }
    }
    return array;
}

int[,] arr = FillArray(3, 5);
PrintArray(arr, "Случайный массив:");
arr = OrderingNumbersInLines(arr);
PrintArray(arr, "Массив с упорядоченными по убыванию числами в каждой строке:");
