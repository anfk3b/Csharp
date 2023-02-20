Console.Write("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1) Console.WriteLine("Это не день недели");
else
{
    if (a <= 5) Console.WriteLine("Это рабочий день");
    else
    {
        if (a <= 7) Console.WriteLine("Это выходной день");
        else Console.WriteLine("Это не день недели");
    }
}