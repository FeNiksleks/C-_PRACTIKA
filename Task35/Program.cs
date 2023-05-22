// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int[] arr, string sep )
{
     for (int i = 0; i < arr.Length; i++)
     {
    if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
    else Console.Write($"{arr[i]}");

     }
}

int SeachTwoDigitsNums (int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] >= min && arr[i] <= max) count += 1;        
    }
    return count;
}

Console.WriteLine("Введите минимальное значение интервала: ");
int numbermin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение интервала: ");
int numbermax = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(123, 0, 200);
Console.Write("[");
PrintArray(array, ",");
Console.WriteLine("]");
int seach = SeachTwoDigitsNums(array, numbermin, numbermax);
Console.WriteLine(seach);
Console.WriteLine ($"В массиве {seach} чисел из диапазона [{numbermin}, {numbermax}] ");