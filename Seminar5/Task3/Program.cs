// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GenerateArray(int len)
{
    double[] array = new double[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

double MinMaxDiff(double[] array)
{
    double min = 1, max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    // System.Console.WriteLine(min);
    // System.Console.WriteLine(max);
    return max - min;
}

double[] arr = GenerateArray(5);
PrintArray(arr);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом: {MinMaxDiff(arr)}");
