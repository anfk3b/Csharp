// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int n)
{
    if (n == 0)
        return 0;
    if (n > 0)
        return n % 10 + SumOfDigits(n / 10);
    else
        return (-n) % 10 + SumOfDigits(n / 10);
}

int n = InputInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр: {SumOfDigits(n)}");
