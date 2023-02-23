// Задача 1: Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] arr = { 1, 5, -4, -3, 2, 6, -7, 1, -1 };

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int[] Inverse(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = -array[i];
    return array;
}

PrintArray(arr);
PrintArray(Inverse(arr));
