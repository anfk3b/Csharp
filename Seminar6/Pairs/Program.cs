// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int len, int minValue, int maxValue)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine();
}

int[] MultiplicationPairs(int[] array)
{
    int[] resultArray;
    resultArray = new int[array.Length / 2 + array.Length % 2];
    resultArray[resultArray.Length - 1] = array[resultArray.Length - 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        resultArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return resultArray;
}

int length = InputInt("Введите длину массива");
int[] myArray = CreateArray(length, 1, 9);
PrintArray(myArray);
System.Console.WriteLine("Массив произведений пар:");
PrintArray(MultiplicationPairs(myArray));
