// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит 
// число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int InputInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double PowerAB(int a, int b)
{
    if (b == 0)
        return 1;
    if (b > 0)
        return a * PowerAB(a, b - 1);
    else return (double)PowerAB(a, b + 1) / a;
}

int a = InputInt("Введите число A: ");
int b = InputInt("Введите число B: ");
System.Console.WriteLine($"A в степени B равно {PowerAB(a, b)}");
