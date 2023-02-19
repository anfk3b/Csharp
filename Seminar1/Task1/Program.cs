Console.Write("Введите первое число: ");
string? s1 = Console.ReadLine();
int i1 = Convert.ToInt32(s1);
Console.Write("Введите второе число: ");
string? s2 = Console.ReadLine();
int i2 = Convert.ToInt32(s2);
if (i2 > i1)
{
    Console.WriteLine($"max = {i2}");
}
else
{
    Console.WriteLine($"max = {i1}");
}