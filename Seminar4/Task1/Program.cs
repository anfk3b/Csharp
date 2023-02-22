// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Stepen(int a, int b)
{
    if (b < 1) return -1;
    int res = a;
    int i = 1;
    while (i < b)
    {
        res *= a;
        i++;
    }
    return res;
}

int a = Prompt("Введите число");
int b = Prompt("Введите степень");
int s = Stepen(a, b);

if (s == -1) System.Console.WriteLine("Степень ненатуральная");
else System.Console.WriteLine($"{a} в степени {b} равно {s}");
