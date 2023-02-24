// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

(int, int) InputTuple(string message)
{
    System.Console.Write(message);
    string[] values = Console.ReadLine().Split(' ');
    int x = int.Parse(values[0]);
    int y = int.Parse(values[1]);
    return (x, y);
}

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

int? FindElement(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
        return array[i, j];
    return null;
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
(int i, int j) = InputTuple("Введите индексы элемента через пробел: ");
int? e = FindElement(arr, i, j);
if (e == null)
    System.Console.WriteLine("Такого элемента нет");
else
    System.Console.WriteLine($"Элемент ({i}, {j}) равен {e}");
