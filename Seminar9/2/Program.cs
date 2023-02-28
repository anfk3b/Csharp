// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowNumbers(int m, int n)
{
    if (m > n)
        return;
    System.Console.Write(m);
    if (m < n)
        System.Console.Write(", ");
    ShowNumbers(m + 1, n);
}

int m = InputInt("Введите начало диапазона: ");
int n = InputInt("Введите конец диапазона: ");

ShowNumbers(m, n);
