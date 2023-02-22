// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции.
// (*Доп сложность, "введите количество элементов массива", "Введите минимальный порог случайных значений",
// "Введите максимальный порог случайных значений")

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int min = Prompt("Введите минимальный порог случайных значений");
int max = Prompt("Введите максимальный порог случайных значений");
int qnt = Prompt("Введите количество элементов массива");

if (qnt < 1) System.Console.WriteLine("Неправильное количество элементов");
else
{
    int[] a = new int[qnt];
    for (int i = 0; i < qnt; i++) a[i] = new Random().Next(min, max + 1);
    System.Console.Write("\n[");
    for (int i = 0; i < qnt - 1; i++) System.Console.Write(a[i] + ",");
    System.Console.Write(a[qnt - 1] + "]");
}
