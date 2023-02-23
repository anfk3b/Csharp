// Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. 
// Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 201);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int FindDouble(int[] array)
{
    int qnt = 0;
    foreach (int item in array)
        if (item >= 10 && item <= 99)
            qnt++;
    return qnt;
}

int[] arr = GenerateArray(10);
PrintArray(arr);
System.Console.WriteLine($"Количество двузначных элементов массива: {FindDouble(arr)}");
