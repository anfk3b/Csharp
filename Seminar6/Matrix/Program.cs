// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int[,] GenerateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
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

void MinMax(int[,] array)
{
    int sumMax = 0, sumMin = 0;
    // сумма максимумов по строкам
    int[] max = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max[i])
                max[i] = array[i, j];
        }
        sumMax += max[i];
    }
    System.Console.WriteLine($"Сумма максимумов по строкам: {sumMax}");
    // сумма минимумов по столбцам
    int[] min = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        min[j]=10;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < min[j])
                min[j] = array[i, j];
        }
        sumMin += min[j];
    }
    System.Console.WriteLine($"Сумма минимумов по столбцам: {sumMin}");
    // разница сумм
    System.Console.WriteLine($"Разница суммы максимумов и суммы минимумов: {sumMax-sumMin}");
}

int[,] arr = GenerateArray(3, 4);
PrintArray(arr);
MinMax(arr);
