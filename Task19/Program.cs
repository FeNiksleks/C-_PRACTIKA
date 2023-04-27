// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Comparison(int num)
{
    int num1 = num / 10000;
    int num5 = num % 10;
    int num2 = num / 1000 %10;
    int num4 = num / 10 %10;
    return num1 == num5 && num2 == num4;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = 0;
if (number <0) minusNumber = number;
if (number > 9999 && number < 100000 || minusNumber > -100000 && minusNumber < -9999 )
{
bool result = Comparison(number);
Console.WriteLine(result ? $"{number} -> Да" : $"{number} -> Нет");
}
else
{  
    Console.WriteLine($"Введите пятизначное число!");
}
