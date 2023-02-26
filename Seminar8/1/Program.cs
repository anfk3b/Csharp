// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

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
            array[i, j] = new Random().Next(1, 10);
            // array[i, j] = i + j;
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
}

void Replace(int[,] array)
{
    int maxIndex = array.GetLength(0) - 1;
    int tmp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tmp = array[0, j];
        array[0, j] = array[maxIndex, j];
        array[maxIndex, j] = tmp;
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
Replace(arr);
System.Console.WriteLine();
PrintArray(arr);
