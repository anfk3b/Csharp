int a = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число: {a}");
a = (a / 100) * 10 + a % 10;
Console.WriteLine($"Число без второй цифры: {a}");