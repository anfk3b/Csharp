﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0) a = -a;
if (a < 10000 || a > 99999)
{
    Console.WriteLine("Число не пятизначное");
}
else
{
    if (a / 10000 == a % 10 &&
        a / 1000 % 10 == a / 10 % 10)
        Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}