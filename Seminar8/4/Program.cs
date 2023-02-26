// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.

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
int[,] DeleteMin(int[,] array)
{
    if (array.GetLength(0) <= 1 && array.GetLength(1) <= 1)
        return array;
    int minIndex0 = 0, minIndex1 = 0, min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                minIndex0 = i;
                minIndex1 = j;
                min = array[i, j];
            }
    System.Console.WriteLine($"Удалён элемент ({minIndex0}, {minIndex1}) = {min}\n");
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minIndex0)
            continue;
        int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minIndex1)
                continue;
            result[k, l++] = array[i, j];
        }
        k++;
    }
    return result;
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
int[,] arr2 = DeleteMin(arr);
PrintArray(arr2);
