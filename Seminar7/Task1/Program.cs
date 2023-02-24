// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GenerateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    int tmpVal;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            tmpVal = new Random().Next(-99, 100);
            array[i, j] = (double)tmpVal / 10;
        }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j]}\t");
        System.Console.WriteLine();
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
double[,] arr = GenerateArray(m, n);
PrintArray(arr);
