// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int SecondDigit (int num)
// {
//     int decimalDigit = num % 100;
//     int firstDigit = decimalDigit / 10;
    
//     return firstDigit;
// }
int SecondDigit (int num)
{
    int decimalDigit = num % 100 /10;  
    return decimalDigit < 0 ? decimalDigit * -1 : decimalDigit;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = 0;
if (number <0) minusNumber = number;
if (number >=100 && number <=999 || minusNumber >= -999 && minusNumber <=- 100 )
{
int result = SecondDigit (number);
Console.WriteLine($"Вторая цифра числа {number} => {result}");
}
else
{
    Console.WriteLine($"Число {number} не является трехзначным! Введи корректное число вида ХХХ ");
}
