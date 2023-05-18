// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultiplicationNumbers(int num)
{
    int mul = 1;
    for (int i = 1; i <= num; i++)
    {
        mul = mul * i;
    }
    return mul;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int mulNumbers = MultiplicationNumbers(number);
Console.WriteLine($"{number} -> {mulNumbers}");

