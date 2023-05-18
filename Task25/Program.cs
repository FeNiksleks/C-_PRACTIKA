// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
// Square(numberA, numberB);
int squa = Square(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} -> {squa}");
int Square (int num, int pow)
{
    int sq = num;
   for (int i = 1; i < pow; i++)
   {
    sq = sq * num;
   }
   return sq;
        // Console.WriteLine($"{num} в степени {pow} -> {Math.Pow(num, pow)}");
        // Console.WriteLine($"{num} в степени {pow} -> {sq}");
    }