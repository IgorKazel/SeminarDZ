void PrintArray(int[,] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
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

bool CheckNumber(int number)
{
    if (number < 2)
    {
        return true;
    }
    return false;
}


int n = NumberEntry("Введите количество строк (столбцов) квадратного массива");
if (CheckNumber(n))
{
    Console.WriteLine("Количество строк (столбцов) не может быть меньше 2");
    return;
}
int[,] array = new int[n, n];
int index = 1;
int limitMax = array.GetLength(0) - 1;
int limitMin = 0;

void FillArray(int i, int j)
{
    while (j < limitMax)
    {
        array[i, j] = index;
        index++;
        j++;
    }
    while (i < limitMax)
    {
        array[i, j] = index;
        index++;
        i++;
    }
    while (j > limitMin)
    {
        array[i, j] = index;
        index++;
        j--;
    }
    while (i > limitMin)
    {
        array[i, j] = index;
        index++;
        i--;
    }
    limitMax--;
    limitMin++;
    if (index < array.Length)
    {
        FillArray(i + 1, j + 1);
    }
    else if (array.Length % 2 == 1)
    {
        array[i + 1, j + 1] = array.Length;
    }
}

FillArray(0, 0);
PrintArray(array, "Массив заполненный спирально:");
