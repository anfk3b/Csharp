// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int F(int a)
{
    if (a == 1) return 1;
    else return a * F(a - 1);
}

int a = Prompt("Введите число");
System.Console.WriteLine($"Факториал числа: {F(a)}");
