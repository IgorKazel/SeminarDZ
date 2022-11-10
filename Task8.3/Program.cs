int[,] FillArray(int line, int column)
{
    int[,] array = new int[line, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 6);
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

bool CheckMatrix(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы");
        return false;
    }
    return true;
}

int[,] MatrixProduct(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}

int[,] matrix1 = FillArray(2, 3);
PrintArray(matrix1, "Первая случайная матрица:");
int[,] matrix2 = FillArray(3, 2);
PrintArray(matrix2, "Вторая случайная матрица:");
if (CheckMatrix(matrix1, matrix2))
{
    int[,] resultMatrix = MatrixProduct(matrix1, matrix2);
    PrintArray(resultMatrix, "Произведение матриц:");
}
