// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] primeNumbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59,
                    61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131,
                    137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211};

bool IsPrime(int n)
{
    if (n == 1)
        return false;
    for (int i = 0; i < primeNumbers.Length; i++)
    {
        if (n == primeNumbers[i])
            return true;
        if (n % primeNumbers[i] == 0)
            return false;
    }
    return true;
}


for (int n = 1; n < 40000; n++)
{
    if (IsPrime(n))
    {
        // Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write(n + ", ");
        // System.Console.WriteLine($"Число {n} простое");
        // Console.ResetColor();
    }
    // else System.Console.WriteLine($"Число {n} составное");
}


// int n = InputInt("Введите число (до 40 000): ");
// if (IsPrime(n))
//     System.Console.WriteLine($"Число {n} простое");
// else
//     System.Console.WriteLine($"Число {n} составное");
