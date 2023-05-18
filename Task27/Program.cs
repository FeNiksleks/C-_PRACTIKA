// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberLen(int a)
{
    int count = 0;
    while (a != 0)
    {
        a /= 10;
        count++;
    }
    return count;
}

int SummerNumbers(int a, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = NumberLen(number);
int result = SummerNumbers(number, count);
Console.WriteLine($"{number} => {result}");