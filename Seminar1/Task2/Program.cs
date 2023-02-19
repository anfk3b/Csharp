Console.Write("Введите первое число: ");
string? s1 = Console.ReadLine();
int i1 = Convert.ToInt32(s1);

Console.Write("Введите второе число: ");
string? s2 = Console.ReadLine();
int i2 = Convert.ToInt32(s2);

Console.Write("Введите третье число: ");
string? s3 = Console.ReadLine();
int i3 = Convert.ToInt32(s3);

if (i2 > i1)
{
    if (i3 > i2) Console.WriteLine($"max = {i3}");
    else Console.WriteLine($"max = {i2}");
}
else
{
    if (i3 > i1) Console.WriteLine($"max = {i3}");
    else Console.WriteLine($"max = {i1}");
}