// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int m, int n)
{
    if (m > n)
        return 0;
    return m + Sum(m + 1, n);
}

int m = InputInt("Введите начало диапазона: ");
int n = InputInt("Введите конец диапазона: ");
System.Console.WriteLine($"Сумма натуральных чисел диапазона: {Sum(m, n)}");
