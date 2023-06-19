// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NaturalNumberCounter (int number)
{
    // if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write($"{number} ");
    NaturalNumberCounter (number - 1);
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.Write($"{number} не натуральное число");
}
else
{
    NaturalNumberCounter (number);
}
