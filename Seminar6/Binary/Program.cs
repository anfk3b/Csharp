// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string GetBinary(int a)
{
    string s = string.Empty;
    while (a > 0)
    {
        s = Convert.ToString(a % 2) + s;
        a /= 2;
    }
    return s;
}

int num = InputInt("Введите число: ");
System.Console.WriteLine($"Двоичное представление: {GetBinary(num)}");
