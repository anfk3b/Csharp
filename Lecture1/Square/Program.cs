/*
Console.Write("Введите число: ");
string s = Console.ReadLine();
int c = Convert.ToInt32(s);
Console.WriteLine($"Квадрат числа: {c*c}");
*/

Console.Write("Введите первое число: ");
string s1 = Console.ReadLine();
int c1 = Convert.ToInt32(s1);
Console.Write("Введите второе число: ");
string s2 = Console.ReadLine();
int c2 = Convert.ToInt32(s2);
if (c2 == c1 * c1)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}