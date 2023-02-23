// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Poisk(int[] array, int a)
{
    bool found = false;
    foreach (int item in array)
        if (item == a)
            found = true;
    if (found)
        System.Console.WriteLine($"Элемент {a} присутствует в массиве");
    else
        System.Console.WriteLine($"Элемент {a} не присутствует в массиве");
}

int[] arr = GenerateArray(12);
PrintArray(arr);
int num = InputInt("Введите число для поиска: ");
Poisk(arr, num);
