Console.Write("Введите трёхзначное число: ");
int i = Convert.ToInt32(Console.ReadLine());
if (i < 0) i = -i;
if (i < 100 || i > 999)
{
    Console.WriteLine("Число не трёхзначное");
}
else
{
    i = i % 100;
    i = i / 10;
    Console.WriteLine($"Вторая цифра: {i}");
}