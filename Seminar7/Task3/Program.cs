// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void PrintAverage(int[,] array)
{
    System.Console.Write("Среднее по столбцам: ");
    double sum;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
        System.Console.Write($"{sum / array.GetLength(0):#.##}  ");
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
PrintAverage(arr);
