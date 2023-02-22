// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Calc(int chislo)
{
    if (chislo == 0) return 1;
    int i = 0;
    while (chislo != 0)
    {
        i++;
        chislo = chislo / 10;
    }
    return i;
}

int a = Prompt("Введите число");
System.Console.WriteLine($"Количество цифр числа: {Calc(a)}");
