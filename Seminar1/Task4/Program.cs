Console.Write("Введите число: ");
string? s = Console.ReadLine();
int i = Convert.ToInt32(s);
int j = 1;

while (j <= i)
{
    if (j % 2 == 0) Console.Write($"{j} ");
    j++;
}