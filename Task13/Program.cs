// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int ThirdDigit (int num)
// {
//     int thirdDigit = num % 10;  
//     return thirdDigit < 0 ? thirdDigit * -1 : thirdDigit;
// }

int ThirdDigit (int num)
{
int minusnum = 0;
if (num < 0) 
{   
    minusnum = num * -1;
    while (minusnum > 999 )
    {
    
        num = num / 10;
        minusnum = num * -1;
    }
    int thirdDigit = num % 10;  
    return thirdDigit < 0 ? thirdDigit * -1 : thirdDigit;
}
else 
{
    while (num > 999 )
    {
    
        num = num / 10;
    }
    int thirdDigit = num % 10;  
    return thirdDigit < 0 ? thirdDigit * -1 : thirdDigit;
}
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int minusNumber = 0;
if (number <0) minusNumber = number;
if (number > 0 && number < 100 || minusNumber > -100 && minusNumber < 0 )
{
    Console.WriteLine($"Третьей цифры у числа {number} нет");
}
else
{
int result = ThirdDigit (number);
Console.WriteLine($"Третья цифра числа {number} => {result}");
}
