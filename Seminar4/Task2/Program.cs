// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int a)
{
    int res = 0;
    if (a < 0) a = -a;
    while (a > 0)
    {
        res += a % 10;
        a /= 10;
    }
    return res;
}

int a = Prompt("Введите число");
System.Console.WriteLine($"Сумма цифр: {Sum(a)}");
