// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string str = string.Empty;
            if (array[i, j] < 100) str += " ";
            if (array[i, j] < 10) str += " ";
            str += Convert.ToString(array[i, j]) + " ";
            System.Console.Write(str);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void FillArray(int[,] array, int x, int y, int n, int direction)
{
    array[x, y] = n;
    switch (direction)
    {
        case 0: // вправо
            if (y + 1 < array.GetLength(1) && array[x, y + 1] == 0)
                FillArray(array, x, y + 1, n + 1, 0);
            if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0)
                FillArray(array, x + 1, y, n + 1, 1);
            if (y - 1 >= 0 && array[x, y - 1] == 0)
                FillArray(array, x, y - 1, n + 1, 2);
            if (x - 1 >= 0 && array[x - 1, y] == 0)
                FillArray(array, x - 1, y, n + 1, 3);
            break;
        case 1: // вниз
            if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0)
                FillArray(array, x + 1, y, n + 1, 1);
            if (y - 1 >= 0 && array[x, y - 1] == 0)
                FillArray(array, x, y - 1, n + 1, 2);
            if (x - 1 >= 0 && array[x - 1, y] == 0)
                FillArray(array, x - 1, y, n + 1, 3);
            if (y + 1 < array.GetLength(1) && array[x, y + 1] == 0)
                FillArray(array, x, y + 1, n + 1, 0);
            break;
        case 2: // влево
            if (y - 1 >= 0 && array[x, y - 1] == 0)
                FillArray(array, x, y - 1, n + 1, 2);
            if (x - 1 >= 0 && array[x - 1, y] == 0)
                FillArray(array, x - 1, y, n + 1, 3);
            if (y + 1 < array.GetLength(1) && array[x, y + 1] == 0)
                FillArray(array, x, y + 1, n + 1, 0);
            if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0)
                FillArray(array, x + 1, y, n + 1, 1);
            break;
        case 3: // вверх
            if (x - 1 >= 0 && array[x - 1, y] == 0)
                FillArray(array, x - 1, y, n + 1, 3);
            if (y + 1 < array.GetLength(1) && array[x, y + 1] == 0)
                FillArray(array, x, y + 1, n + 1, 0);
            if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0)
                FillArray(array, x + 1, y, n + 1, 1);
            if (y - 1 >= 0 && array[x, y - 1] == 0)
                FillArray(array, x, y - 1, n + 1, 2);
            break;
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
if (m > 0 && n > 0)
{
    int[,] arr = new int[m, n];
    FillArray(arr, 0, 0, 1, 0);
    PrintArray(arr);
}
