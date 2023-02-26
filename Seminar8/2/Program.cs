// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
    if (array.GetLength(0) == array.GetLength(1))
    {
        int tmp;
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                tmp = array[j, i];
                array[j, i] = array[i, j];
                array[i, j] = tmp;
            }
    }
    else
    {
        System.Console.WriteLine("Невозможно заменить строки на столбцы");
        System.Console.WriteLine();
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
Replace(arr);
System.Console.WriteLine();
PrintArray(arr);
