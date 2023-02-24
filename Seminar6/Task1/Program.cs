// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InputArray(int qnt)
{
    int[] res = new int[qnt];
    for (int i = 0; i < qnt; i++)
    {
        System.Console.Write($"Введите {i + 1}-е число: ");
        res[i] = Convert.ToInt32(Console.ReadLine());
    }
    return res;
}

int CountPositive(int[] array)
{
    int count = 0;
    foreach (int item in array)
        if (item > 0)
            count++;
    return count;
}

int m = InputInt("Количество чисел для ввода: ");
int[] arr = InputArray(m);
System.Console.WriteLine($"Количество положительных чисел: {CountPositive(arr)}");
