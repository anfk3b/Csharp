// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает 
// по убыванию элементы каждой строки двумерного массива.

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

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int l = j, max = array[i, j];
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    l = k;
                }
            if (l > j)
            {
                int tmp = array[i, j];
                array[i, j] = array[i, l];
                array[i, l] = tmp;
            }
        }
    }
}


int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
System.Console.WriteLine("Сортировка строк: ");
SortRows(arr);
PrintArray(arr);
