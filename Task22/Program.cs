// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

Square(number, degree);
void Square (int num, int pow)
{
        int count = 1;
    while (count <= num)
{
    
        Console.WriteLine($"{count,3}  {Math.Pow(count, pow),5}"); //Math.Pow((x2 - x1), 2)
            
    count++;
}
}
// /10000 = %10 &&  %10000 = %100 / 10