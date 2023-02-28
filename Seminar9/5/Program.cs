// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Remainder(int n)
{
    if (n <= 1)
        return 0;
    return n % 2 + Remainder(n / 2);
}

int n = InputInt("Введите число: ");
if (n < 1)
{
    System.Console.WriteLine($"Число {n} не является степенью двойки");
    System.Console.ReadLine();
    System.Environment.Exit(0);
}
if (Remainder(n) == 0)
    System.Console.WriteLine($"Число {n} является степенью двойки");
else System.Console.WriteLine($"Число {n} не является степенью двойки");
