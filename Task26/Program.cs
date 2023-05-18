// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int QuantityNumber (int num)
{
    int count = 0;
    while(num !=0)
    {
        num /=10;
        count++;
    }
    return count;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int result = QuantityNumber (number);
Console.WriteLine($"{number} => {result}");

