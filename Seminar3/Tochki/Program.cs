// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Distance(double x1, double x2, double y1, double y2)
{
    double a, b;
    a = x2 - x1;
    b = y2 - y1;
    return Math.Sqrt(a * a + b * b);
}

int x1 = Prompt("Введите координату X первой точки");
int y1 = Prompt("Введите координату Y первой точки");
int x2 = Prompt("Введите координату X второй точки");
int y2 = Prompt("Введите координату Y второй точки");

System.Console.WriteLine($"Расстояние между точками: {Distance(x1, x2, y1, y2)}");
