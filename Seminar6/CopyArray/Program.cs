// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 201);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] res = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[i];
    }
    return res;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int[] ar1 = GenerateArray(10);
int[] ar2 = CopyArray(ar1);
PrintArray(ar1);
PrintArray(ar2);
