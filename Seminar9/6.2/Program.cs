// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int number, int divider)
{
    if (divider == 1)
        return true;
    if (number % divider == 0)
        return false;
    divider--;
    return Validate(number, divider);
}

bool Starter(int number)
{
    return Validate(number, number - 1);
}

int n = InputInt("Введите число: ");
if (Starter(n))
    System.Console.WriteLine($"Число {n} простое");
else
    System.Console.WriteLine($"Число {n} составное");
