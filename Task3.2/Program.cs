const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] InputPoint(int point)
{
    int[] answer = new int[3];
    answer[X] = Prompt($"Введите x{point} -> ");
    answer[Y] = Prompt($"Введите y{point} -> ");
    answer[Z] = Prompt($"Введите z{point} -> ");
    return answer;
}

int Square(int arg)
{
    return arg * arg;
}

int[] p1 = InputPoint(1);
int[] p2 = InputPoint(2);
double length = Math.Sqrt(Square(p1[X] - p2[X]) + Square(p1[Y] - p2[Y]) + Square(p1[Z] - p2[Z]));
Console.WriteLine($"Расстояние между двумя точками - {length:f2}");
