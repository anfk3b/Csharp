// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMult(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for (int k = 0; k < array1.GetLength(1); k++)
                result[i, j] += array1[i, k] * array2[k, j];
    return result;
}

int k = InputInt("Введите количество строк: ");
int l = InputInt("Введите количество столбцов: ");
int[,] arr1 = GenerateArray(k, l);
PrintArray(arr1);

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr2 = GenerateArray(m, n);
PrintArray(arr2);

if (l != m)
    System.Console.WriteLine("Умножать такие матрицы нельзя");
else
{
    System.Console.WriteLine("Произведение матриц:");
    int[,] arr3 = MatrixMult(arr1, arr2);
    PrintArray(arr3);
}