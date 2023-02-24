// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] FindIntersect(int k1, int b1, int k2, int b2)
{
    double[] res = new double[3];
    if (k1 == k2 && b1 == b2)
    {
        res[2] = -1;
        return res;
    }
    if (k1 == k2)
    {
        res[2] = 0;
        return res;
    }
    res[2] = 1;
    res[0] = (double)(b2 - b1) / (k1 - k2);
    res[1] = k1 * res[0] + b1;
    return res;
}

System.Console.WriteLine("Первая прямая: y = k1 * x + b1");
System.Console.WriteLine("Вторая прямая: y = k2 * x + b2");
System.Console.WriteLine();
int k1 = InputInt("Введите k1: ");
int b1 = InputInt("Введите b1: ");
int k2 = InputInt("Введите k2: ");
int b2 = InputInt("Введите b2: ");
System.Console.WriteLine();
double[] intersect = FindIntersect(k1, b1, k2, b2);
switch (intersect[2])
{
    case -1:
        Console.WriteLine($"Параметры задают одну и ту же прямую");
        break;
    case 0:
        Console.WriteLine($"Прямые не пересекаются");
        break;
    default:
        Console.WriteLine($"Координаты точки пересечения: ({intersect[0]}, {intersect[1]})");
        break;
}
