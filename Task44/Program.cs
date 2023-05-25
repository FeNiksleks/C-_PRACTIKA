﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] Fibonacci (int num)
{
    int[] arr = new int[num];
    // arr[0] = 0;
    arr[1] = 1;
    // Random rnd = new Random();
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;

}

void PrintArray (int[] arr, string sep = ",")
{
     for (int i = 0; i < arr.Length; i++)
     {
    if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
    else Console.Write($"{arr[i]}");
    // Console.Write()
    // arr[i] = rnd.Next(min, max + 1)
     }
}



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] fib = Fibonacci(number);
// Console.Write("[");
PrintArray(fib);
// Console.WriteLine("]");


