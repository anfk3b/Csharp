// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckTriangle(int a, int b, int c)
{
    if (a > 0 && b > 0 && c > 0 && a < b + c && b < a + c && c < a + b)
        System.Console.WriteLine("Треугольник с такими сторонами существует");
    else
        System.Console.WriteLine("Треугольник с такими сторонами не существует");
}

int a = InputInt("Введите первое число: ");
int b = InputInt("Введите второе число: ");
int c = InputInt("Введите третье число: ");
CheckTriangle(a, b, c);
