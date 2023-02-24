// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив         Новый массив будет выглядеть
//  выглядел вот так:                  вот так:
// 1 4 7 2                             1  4  7  2
// 5 9 2 3                             5 81  2  9
// 8 4 2 4                             8  4  2  4

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
            array[i, j] = new Random().Next(-9, 10);
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

void PowEven(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
        for (int j = 1; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
PowEven(arr);
System.Console.WriteLine();
PrintArray(arr);
