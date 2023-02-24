// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintFib(int num)
{
    if (num >= 1) System.Console.Write("0 ");
    if (num >= 2) System.Console.Write("1 ");
    int a = 0, b = 1, tmp = 0, i = 2;
    while (i < num)
    {
        tmp = a + b;
        System.Console.Write($"{tmp} ");
        a = b;
        b = tmp;
        i++;
    }
}

int n = InputInt("Введите количество чисел Фибоначчи: ");
PrintFib(n);
