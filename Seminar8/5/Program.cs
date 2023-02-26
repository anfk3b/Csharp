// Задача 5: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateLine(int n)
{
    int[] line = new int[n];
    line[0] = 1;
    line[n - 1] = 1;
    if (n > 2)
    {
        int[] prevLine = GenerateLine(n - 1);
        for (int i = 1; i < n - 1; i++)
        {
            line[i] = prevLine[i - 1] + prevLine[i];
        }
    }
    return line;
}

void PrintLine(int[] line)
{
    int centerPos = 80;
    double length = line.Length;
    int startPos = centerPos - (int)Math.Round(2 * Math.Pow(length, 1.315)
                                             - 7 * Math.Pow(length, 0.8)
                                             + 20 * Math.Pow(length, 0.2));
    for (int i = 0; i < startPos; i++)
        System.Console.Write(" ");
    for (int i = 0; i < line.Length; i++)
        System.Console.Write($"{line[i]} ");
    System.Console.WriteLine();
}

int n = InputInt("Введите количество строк треугольника: ");
for (int i = 1; i <= n; i++)
{
    int[] line = GenerateLine(i);
    PrintLine(line);
}
