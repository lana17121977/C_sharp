﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число a");

int a = Convert.ToInt32(Console.ReadLine());

int c =(a % 2);

if (c ==0)
{
   Console.WriteLine("Четное число  " + a);
}
else
{
    Console.WriteLine("Нечетное число " + a);
}   