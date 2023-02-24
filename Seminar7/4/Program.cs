// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

(int, int) FindElement(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == element)
                return (i, j);
    return (-1, -1);
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
int e = InputInt("Введите элемент для поиска: ");
(int i, int j) = FindElement(arr, e);
if (i == -1)
    System.Console.WriteLine("Такого элемента нет");
else
    System.Console.WriteLine($"Первое вхождение: ({i}, {j})");
