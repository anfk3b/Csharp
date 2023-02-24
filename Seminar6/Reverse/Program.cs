// Напишите программу, которая перевернёт одномерный массив (последний элемент будет 
// на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void Reverse(int[] array)
{
    int tmp;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}

int[] arr = GenerateArray(6);
PrintArray(arr);
Reverse(arr);
PrintArray(arr);
