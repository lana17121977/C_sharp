﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");

int N = Convert.ToInt32(Console.ReadLine());
int i=1;

while (i<=N)
{
int c =(i % 2);
    if (c ==0)
{
   Console.Write(i + ",");
}
i=i+1;
}   