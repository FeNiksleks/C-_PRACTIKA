// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите значение А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение В");
int numberB = Convert.ToInt32(Console.ReadLine());

int remains = Remains(numberA, numberB);
string result = remains != 0 ? $"Не кратно, остаток {remains}" : "кратно";
Console.WriteLine(result);


int Remains (int num1, int num2)
{
    return num1 % num2;
}

