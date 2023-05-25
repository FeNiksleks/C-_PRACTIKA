// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10



string TheCalculusSystem (int num)
{
    string counter = "";
    while (num >= 1)
{
   counter = (num % 2) + counter;
   num = num / 2;
}
    return counter;
}


Console.WriteLine("Введите число в двоичной системе исчисления: ");
int number = Convert.ToInt32(Console.ReadLine());
string binary = TheCalculusSystem(number);
Console.WriteLine($"{number} -> {binary}");
