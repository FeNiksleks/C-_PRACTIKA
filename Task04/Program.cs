﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите значение А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение В");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение C");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberB > numberA)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}
    Console.WriteLine($" Максимальное число {max}");
