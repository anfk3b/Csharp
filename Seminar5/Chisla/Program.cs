// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

int SumSign(int[] array, bool positive = true)
{
    int sign = -1;
    if (positive) sign = 1;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0) sum += array[i];
    }
    return sum;
}

//int sizeOfArray = InputInt("Введите размер массива: ");
int[] array = GenerateArray(12);

// int sum1 = 0, sum2 = 0;
// foreach (int item in array)
// {
//     if (item < 0) sum1 += item;
//     else sum2 += item;
// }

PrintArray(array);
// System.Console.WriteLine($"Сумма отрицательных элементов {sum1}, сумма положительных {sum2}");
System.Console.WriteLine($"Сумма отрицательных элементов {SumSign(array, false)}, сумма положительных {SumSign(array, true)}");
