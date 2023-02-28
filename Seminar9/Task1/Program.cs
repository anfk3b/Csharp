// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintInt(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
        System.Console.Write($"{m} ");
    PrintInt(m + 1, n);
}

int m = InputInt("Введите начало диапазона: ");
int n = InputInt("Введите конец диапазона: ");
PrintInt(m, n);
