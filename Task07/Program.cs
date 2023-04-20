// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number <0) number *= -1;
if (number >=100 && number <=999)
{
int lasNumber = number % 10;
Console.WriteLine($"Последняя цифра числа {number} => {lasNumber}");
}
else
{
    Console.WriteLine($"Число {number} не является трехзначным! Введи корректное число от 100 до 999");
}