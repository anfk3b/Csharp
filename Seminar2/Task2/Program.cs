Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0) a = -a;

// i - номер третьей цифры, начиная справа
int b, i = 1;
b = a / 10;
while (b > 0)
{
    i++;
    b = b / 10;
}
i = i - 2;

// k - множитель третьей цифры
int k = 1, j = 1;
while (j < i) { k = k * 10; j++; }

if (a < 100) Console.WriteLine("Третьей цифры нет");
else
{
    a = a % (k * 10);
    a = a / k;
    Console.WriteLine($"Третья цифра: {a}");
}