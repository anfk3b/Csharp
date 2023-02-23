// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int FindEven(int[] array)
{
    int qnt = 0;
    foreach (int item in array)
        if (item % 2 == 0)
            qnt++;
    return qnt;
}

int[] arr = GenerateArray(10);
PrintArray(arr);
System.Console.WriteLine($"Количество чётных элементов массива: {FindEven(arr)}");
