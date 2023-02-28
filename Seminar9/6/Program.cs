// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

// Это была первая неудачная попытка решить задачу. Она корректно работает только для чисел до 446.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] primeNumbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59,
                    61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131,
                    137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211};

int[] maxPowers = new int[primeNumbers.Length];
for (int i = 0; i < primeNumbers.Length; i++)
    maxPowers[i] = (int)Math.Round(Math.Log(40000) / Math.Log(primeNumbers[i]) + 1);

bool IsPrime(int n)
{
    if (n == 0)
        return false;
    foreach (int item in primeNumbers)
        if (n == item)
            return true;
    int[] powers = new int[primeNumbers.Length];
    int i, prod, currentMultiplier;
    while (powers[primeNumbers.Length - 1] <= maxPowers[primeNumbers.Length - 1])
    {
        prod = 1;
        for (i = 0; i < primeNumbers.Length; i++)
            prod *= (int)Math.Pow(primeNumbers[i], powers[i]);
        if (prod == n) return false;
        for (currentMultiplier = 0; currentMultiplier < primeNumbers.Length; currentMultiplier++)
        {
            bool allZeros = true;
            for (i = 0; i < currentMultiplier; i++)
                if (powers[i] != 0)
                    allZeros = false;
            if (prod > n && allZeros && currentMultiplier != primeNumbers.Length - 1)
            {
                // if (currentMultiplier == primeNumbers.Length - 1)
                //     return true;
                continue;
            }
            if (prod > n && currentMultiplier == primeNumbers.Length - 1 && powers[currentMultiplier] >= maxPowers[currentMultiplier])
            {
                return true;
            }
            if (powers[currentMultiplier] < maxPowers[currentMultiplier])
            {
                powers[currentMultiplier]++;
                for (i = 0; i < currentMultiplier; i++)
                    powers[i] = 0;
                break;
            }
        }
    }
    return true;
}

// for (int i = 0; i < primeNumbers.Length; i++)
//     System.Console.WriteLine(maxPowers[i] + " ");
// System.Console.WriteLine();

// int n = InputInt("Введите число (до 40 000): ");
for (int n = 1; n < 1000; n++)
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
