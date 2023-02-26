// Задача 3: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию 
// о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9

//  Набор данных
// Частотный массив

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза


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
}

int[] CountFrequency(int[,] array)
{
    int[] result = new int[10];
    foreach (var item in array)
        result[item]++;
    return result;
}

void ShowFrequencies(int[] freq)
{
    for (int i = 0; i < freq.Length; i++)
    {
        if (freq[i] % 10 == 1 || freq[i] % 10 >= 5)
            System.Console.WriteLine($"Элемент {i} встречается {freq[i]} раз");
        if (freq[i] % 10 >= 2 && freq[i] % 10 <= 4)
            System.Console.WriteLine($"Элемент {i} встречается {freq[i]} раза");
    }
}

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arr = GenerateArray(m, n);
PrintArray(arr);
int[] frequencies = CountFrequency(arr);
System.Console.WriteLine();
ShowFrequencies(frequencies);
