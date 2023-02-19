Console.Write("Введите число: ");
string? s = Console.ReadLine();
int i = Convert.ToInt32(s);

if (i % 2 == 0)
{
    Console.WriteLine($"Число {i} чётное");
}
else
{
    Console.WriteLine($"Число {i} нечётное");
}