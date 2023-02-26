// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

(int, int[]) FindRow(int[,] array)
{
    // суммы
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] += array[i, j];
    // одна строка
    int minSum = sum[0];
    int[] result = new int[array.GetLength(1)];
    if (array.GetLength(0) <= 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            result[j] = array[0, j];
        return (minSum, result);
    }
    // несколько строк
    int k = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (sum[i] < minSum)
        {
            minSum = sum[i];
            k = i;
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
        result[j] = array[k, j];
    return (minSum, result);
}


int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
(int sum, int[] res) = FindRow(arr);
System.Console.Write($"Строка с наименьшей суммой элементов: ({sum})  ");
for (int j = 0; j < res.Length; j++)
    System.Console.Write($"{res[j]} ");
